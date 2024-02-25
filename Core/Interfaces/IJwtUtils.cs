using sn_project_be.Core.Models.JWT;
using sn_project_be.Core.Models.Users;
using sn_project_be.Data;

namespace sn_project_be.Core.Interfaces;

public interface IJwtUtils
{
    public Task<string> GenerateJwtToken(ApiUser user);
    public JwtResponseDto? ValidateJwtToken(string token);
    Task<string> CreateRefreshToken(ApiUser user);
    Task<AuthResponseDto?> VerifyRefreshToken(RefreshTokenDto request);
}
