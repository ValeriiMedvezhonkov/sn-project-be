using sn_project_be.Data;

namespace sn_project_be.Core.Models.Users;

public class PostWithUserData
{
    // public ApiUser? ApiUser { get; set; }
    // public Post Post { get; set; }

    public Guid PostId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    
    public Guid UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? ProfilePicUrl { get; set; }
}
