using AutoMapper;
using Microsoft.AspNetCore.Identity;
using sn_project_be.Core.Interfaces;
using sn_project_be.Core.Models.Users;
using sn_project_be.Data;

namespace sn_project_be.Core.Repository;

public class AuthManager : IAuthManager
{
    private readonly IMapper _mapper;
    private readonly UserManager<ApiUser> _userManager;
    private readonly ILogger<AuthManager> _logger;
    private readonly IJwtUtils _jwtService;

    public AuthManager(IMapper mapper, UserManager<ApiUser> userManager, IJwtUtils jwtService, ILogger<AuthManager> logger)
    {
        _mapper = mapper;
        _userManager = userManager;
        _logger = logger;
        _jwtService = jwtService;
    }
    
    public async Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto)
    {
        var user = _mapper.Map<ApiUser>(userDto);
        user.UserName = userDto.Email;

        var result = await _userManager.CreateAsync(user, userDto.Password);

        if (result.Succeeded)
        {
            await _userManager.AddToRoleAsync(user, "User");
        }

        return result.Errors;
    }

    public async Task<AuthResponseDto?> Login(LoginDto loginDto)
    {
        _logger.LogInformation($"Looking for user with email {loginDto.Email}");
        var user = await _userManager.FindByEmailAsync(loginDto.Email);
        if (user == null)
        {
            _logger.LogWarning($"User with email {loginDto.Email} was not found");
            return null;
        }
        var isValidUser = await _userManager.CheckPasswordAsync(user, loginDto.Password);
            
        if(isValidUser == false)
        {
            _logger.LogWarning($"User with email {loginDto.Email} was found, but password is incorrect");
            return null;
        }

        var token = await _jwtService.GenerateJwtToken(user);
        _logger.LogInformation($"Token generated for user with email {loginDto.Email} | Token: {token}");

        return new AuthResponseDto
        {
            Token = token,
            UserProfile = user,
            RefreshToken = await _jwtService.CreateRefreshToken(user)
        };
    }

    public async Task<AuthResponseDto?> RefreshToken( RefreshTokenDto refreshTokenDto)
    {
        var a = await _jwtService.VerifyRefreshToken(refreshTokenDto);
        return a;
    }
}