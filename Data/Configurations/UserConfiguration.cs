using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace sn_project_be.Data.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<ApiUser>
{

    private readonly SnDbContext _context;

    public UserConfiguration(SnDbContext context)
    {
        _context = context;
    }
    
    public void Configure(EntityTypeBuilder<ApiUser> builder)
    {
        var userAdmin = new ApiUser()
        {
            Id = _context.AdminId,
            FirstName = "Admin",
            LastName = "Admin",
            Email = "admin285@gmail.com",
            NormalizedEmail = "admin285@gmail.com".ToUpper(),
            UserName = "AkihitoAdmin",
            NormalizedUserName = "AkihitoAdmin".ToUpper(),
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            SecurityStamp = Guid.NewGuid().ToString("D"),
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        };
        
        var adminPassword = new PasswordHasher<ApiUser>();
        var adminHashedPassword = adminPassword.HashPassword(userAdmin, "from1to0");
        userAdmin.PasswordHash = adminHashedPassword;
        
        var user = new ApiUser()
        {
            Id =  _context.UserId,
            FirstName = "Valerii",
            LastName = "Medvezhonkov",
            Email = "medvezhonkov285@gmail.com",
            NormalizedEmail = "medvezhonkov285@gmail.com".ToUpper(),
            UserName = "Akihito",
            NormalizedUserName = "Akihito".ToUpper(),
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            SecurityStamp = Guid.NewGuid().ToString("D"),
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        };
        
        var userPassword = new PasswordHasher<ApiUser>();
        var userHashedPassword = userPassword.HashPassword(user, "from1to0");
        user.PasswordHash = userHashedPassword;
        
        builder.HasData(userAdmin, user);
    }
}