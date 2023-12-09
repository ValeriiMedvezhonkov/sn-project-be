using System.Security.Claims;

namespace sn_project_be.Core.Models.JWT;

public class JwtResponseDto
{
    public string UserId { get; set; }
    public IEnumerable<Claim> Claims { get; set; }
}