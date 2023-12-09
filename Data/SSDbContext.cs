using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using sn_project_be.Core.Interfaces;
using sn_project_be.Data.Configurations;

namespace sn_project_be.Data;

public class SsDbContext : IdentityDbContext<ApiUser, IdentityRole<Guid>, Guid>
{
    public SsDbContext(DbContextOptions options) : base(options)
    { }
    
    public DbSet<ApiUser> Users { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<User_Post> UserPosts { get; set; }
    
    public DbSet<Friendship> Friendships { get; set; }

    public Guid AdminRoleId = Guid.NewGuid();
    public Guid UserRoleId = Guid.NewGuid();

    public Guid AdminId = Guid.NewGuid();
    public Guid UserId = Guid.NewGuid();
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        // Configure the identity tables
        modelBuilder.ApplyConfiguration(new RoleConfiguration(this));
        modelBuilder.ApplyConfiguration(new UserConfiguration(this));
        modelBuilder.ApplyConfiguration(new UserRoleConfiguration(this));
        
        modelBuilder.Entity<User_Post>()
            .HasOne(b => b.Post)
            .WithMany(ba => ba.UserPosts)
            .HasForeignKey(bi => bi.PostId);

        modelBuilder.Entity<User_Post>()
            .HasOne(b => b.User)
            .WithMany(ba => ba.UserPosts)
            .HasForeignKey(bi => bi.UserId);
        
        modelBuilder.Entity<Friendship>()
            .HasOne(f => f.SenderUser)
            .WithMany(u => u.Friendships)
            .HasForeignKey(f => f.SenderUserId);

        modelBuilder.Entity<Friendship>()
            .HasOne(f => f.ReceiverUser)
            .WithMany()
            .HasForeignKey(f => f.ReceiverUserId);
    }
    
    public override int SaveChanges()
    {
        AddTimestamps();
        return base.SaveChanges();
    }
    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        AddTimestamps();
        return await base.SaveChangesAsync(cancellationToken);
    }
    
    private void AddTimestamps()
    {
        var entities = ChangeTracker.Entries()
            .Where(x => x is { Entity: IBaseEntity, State: EntityState.Added or EntityState.Modified });

        foreach (var entity in entities)
        {
            var now = DateTime.UtcNow; // current datetime

            if (entity.State == EntityState.Added)
            {
                ((IBaseEntity)entity.Entity).CreatedAt = now;
            }
            ((IBaseEntity)entity.Entity).UpdatedAt = now;
        }
    }
}
