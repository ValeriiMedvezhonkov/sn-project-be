using sn_project_be.Data;

namespace sn_project_be.Core.Models.Users;

public class AuthResponseDto
{
    public ApiUser UserProfile { get; set; }
    public string Token { get; set; }
    public string RefreshToken { get; set; }
}