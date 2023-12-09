using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace sn_project_be.Data.Configurations;

public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<Guid>>
{
    private readonly SsDbContext _context;

    public UserRoleConfiguration(SsDbContext context)
    {
        _context = context;
    }

    public void Configure(EntityTypeBuilder<IdentityUserRole<Guid>> builder)
    {
        builder.HasData(new IdentityUserRole<Guid>
            {
                RoleId = _context.AdminRoleId,
                UserId = _context.AdminId
            },
            new IdentityUserRole<Guid>
            {
                RoleId = _context.UserRoleId,
                UserId = _context.UserId
            });
    }
}