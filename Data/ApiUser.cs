using Microsoft.AspNetCore.Identity;
using System.Text.Json.Serialization;
using sn_project_be.Core.Interfaces;

namespace sn_project_be.Data;

public class ApiUser : IdentityUser<Guid>, IBaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? ProfilePicUrl { get; set; }
    
    //Navigations Properties
    [JsonIgnore]
    public List<User_Post> UserPosts { get; set; }
    [JsonIgnore]
    public ICollection<Friendship> Friendships { get; set; }
    
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    
    
    // JSON IGNORE UNNECESSARY PROPS
    [JsonIgnore]
    public override string? PasswordHash { get; set; }
    
    [JsonIgnore]
    public override string? SecurityStamp { get; set; }
    
    [JsonIgnore]
    public override string? NormalizedUserName { get; set; }
    
    [JsonIgnore]
    public override string? NormalizedEmail { get; set; }
    
    [JsonIgnore]
    public override string? ConcurrencyStamp { get; set; }
    
    [JsonIgnore]
    public override string? PhoneNumber { get; set; }
        
    [JsonIgnore]
    public override bool PhoneNumberConfirmed { get; set; }
            
    [JsonIgnore]
    public override bool TwoFactorEnabled { get; set; }
                
    [JsonIgnore]
    public override DateTimeOffset? LockoutEnd { get; set; }
                    
    [JsonIgnore]
    public override bool LockoutEnabled { get; set; }
                        
    [JsonIgnore]
    public override int AccessFailedCount { get; set; }
}
