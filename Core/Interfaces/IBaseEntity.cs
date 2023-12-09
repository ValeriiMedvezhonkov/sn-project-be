namespace sn_project_be.Core.Interfaces;

public interface IBaseEntity
{
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}