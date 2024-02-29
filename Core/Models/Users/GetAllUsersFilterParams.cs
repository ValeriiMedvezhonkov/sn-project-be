namespace sn_project_be.Core.Models.Users;

public abstract class GetAllUsersFilterParams
{
    public string Email { get; set; }
    public string Username { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
