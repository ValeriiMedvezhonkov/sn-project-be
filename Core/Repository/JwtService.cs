
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using sn_project_be.Core.Interfaces;
using sn_project_be.Core.Models.JWT;
using sn_project_be.Core.Models.Users;
using sn_project_be.Data;

namespace sn_project_be.Core.Repository;

public class JwtService: IJwtUtils
{
    private readonly SnDbContext _context;
    private readonly UserManager<ApiUser> _userManager;
    private readonly IConfiguration _configuration;
    
    private const string LoginProvider = "SnBackendApi";
    private const string RefreshToken = "RefreshToken";
    
    public JwtService(SnDbContext context,  UserManager<ApiUser> userManager, IConfiguration configuration ) {
        _context = context;
        _userManager = userManager;
        _configuration = configuration;
    }
    
    public async Task<string> GenerateJwtToken(ApiUser user)
    {
        var roles = await _userManager.GetRolesAsync(user);
        var roleClaims = roles.Select(x => new Claim(ClaimTypes.Role, x)).ToList();
        var userClaims = await _userManager.GetClaimsAsync(user);
    
        var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim("uid", user.Id.ToString()),
            }
            .Union(userClaims).Union(roleClaims);
        
        var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSettings:Key"]));
        var token = new JwtSecurityToken(
            issuer: _configuration["JwtSettings:Issuer"],
            audience: _configuration["JwtSettings:Audience"],
            expires: DateTime.Now.AddMinutes(30),
            claims: claims,
            signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
        );
        return new JwtSecurityTokenHandler().WriteToken(token);
    }
    
    public JwtResponseDto? ValidateJwtToken(string token)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        try {
            tokenHandler.ValidateToken(token, new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidAudience = _configuration["JwtSettings:Audience"],
                ValidIssuer = _configuration["JwtSettings:Issuer"],
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSettings:Key"])),
                // set clockskew to zero so tokens expire exactly at token expiration time (instead of 5 minutes later)
                ClockSkew = TimeSpan.Zero
            }, out var validatedToken);
    
            var jwtToken = (JwtSecurityToken)validatedToken;
            var userId = jwtToken.Claims.First(x => x.Type == "uid").Value;

            var jwtResponse = new JwtResponseDto()
            {
                UserId = userId,
                Claims = jwtToken.Claims
            };
            // return user id and jwt claims from JWT token if validation successful
            return jwtResponse;
        } catch {
            // return null if validation fails
            return null;
        }
    }
    
    public async Task<string> CreateRefreshToken(ApiUser user)
    {
        await _userManager.RemoveAuthenticationTokenAsync(user, LoginProvider, RefreshToken);
        var newRefreshToken = await _userManager.GenerateUserTokenAsync(user, LoginProvider, RefreshToken);
        await _userManager.SetAuthenticationTokenAsync(user, LoginProvider, RefreshToken, newRefreshToken);
        return newRefreshToken;
    }
    
    public async Task<AuthResponseDto?> VerifyRefreshToken(RefreshTokenDto request)
    {
        var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
        var tokenContent = jwtSecurityTokenHandler.ReadJwtToken(request.Token);
        var username = tokenContent.Claims.ToList().FirstOrDefault(q => q.Type == JwtRegisteredClaimNames.Email)?.Value;
        if (username == null)
        {
            return null;
        }
        var user = await _userManager.FindByEmailAsync(username);
    
        if(user == null || user.Id.ToString() != request.UserId)
        {
            return null;
        }
    
        var isValidRefreshToken = await _userManager.VerifyUserTokenAsync(user, LoginProvider, RefreshToken, request.RefreshToken);
    
        if (isValidRefreshToken)
        {
            var token = await GenerateJwtToken(user);
            return new AuthResponseDto
            {
                Token = token,
                UserProfile = user,
                RefreshToken = await CreateRefreshToken(user)
            };
        }
    
        await _userManager.UpdateSecurityStampAsync(user);
        return null;
    }
}