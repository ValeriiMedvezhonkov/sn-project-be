using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace sn_project_be.Core.Models.Users;

public class ApiUserDto : LoginDto
{
    [Required]
    [DefaultValue("Valerii")]
    public string FirstName { get; set; }

    [Required]
    [DefaultValue("Medvezhonkov")]
    public string LastName { get; set; }
}
