namespace sn_project_be.Core.Models.Users;

public class GetUserDto
{
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public Guid Id { get; set; }
    public bool emailConfirmed  { get; set; }
}