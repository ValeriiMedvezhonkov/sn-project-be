
using sn_project_be.Core.Interfaces;
using sn_project_be.Data;

namespace sn_project_be.Data;

public class User_Post: IBaseEntity
{
    public Guid Id { get; set; }
    
    public Guid UserId { get; set; }
    public ApiUser User { get; set; }


    public Guid PostId { get; set; }
    public Post Post { get; set; }
    
    
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}