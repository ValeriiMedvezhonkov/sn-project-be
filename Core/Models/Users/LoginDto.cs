using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace sn_project_be.Core.Models.Users;

public class LoginDto
{
    [Required]
    [EmailAddress]
    [DefaultValue("mysecretemail@gmail.com")]
    public string Email { get; set; }

    [Required]
    [StringLength(15, ErrorMessage = "Your Password is limited to {2} to {1} characters", MinimumLength = 6)]
    [DefaultValue("Mysecretpass1%")]
    public string Password { get; set; }
}