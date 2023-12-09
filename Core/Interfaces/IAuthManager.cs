using Microsoft.AspNetCore.Identity;
using sn_project_be.Core.Models.Users;

namespace sn_project_be.Core.Interfaces;

public interface IAuthManager
{
    Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto);
    Task<AuthResponseDto> Login(LoginDto loginDto);
}