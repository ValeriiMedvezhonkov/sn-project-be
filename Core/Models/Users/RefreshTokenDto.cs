namespace sn_project_be.Core.Models.Users;

public class RefreshTokenDto
{
    public string Token { get; set; }
    public string RefreshToken { get; set; }
    public string UserId { get; set; }
}