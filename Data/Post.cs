using System.ComponentModel.DataAnnotations;
using sn_project_be.Core.Interfaces;
using System.Text.Json.Serialization;

namespace sn_project_be.Data;

public class Post: IBaseEntity
{
    [Key]
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    
    //Navigation Properties
    [JsonIgnore]
    public List<User_Post> UserPosts { get; set; }
    
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}