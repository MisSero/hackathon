using Microsoft.EntityFrameworkCore;
using Users.Service.Entities;

namespace Users.Service.Database;

public sealed class AppDbContext : DbContext
{
    public DbSet<User> Users => Set<User>();
    public DbSet<Role> Roles => Set<Role>();

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        var role1 = new Role
        {
            Id = 1,
            Name = Enums.Roles.User.ToString(),
        };
        var role2 = new Role
        {
            Id = 2,
            Name = Enums.Roles.Admin.ToString(),
        };

        builder.Entity<Role>().HasData(
            role1,
            role2);

        builder.Entity<User>().HasData(
            new User
            {
                Id = 1,
                Email = "user@gmail.com",
                // пароль - string
                PasswordHash = "AQAAAAIAAYagAAAAEIkUamzDMfkTuzbrabohW9DV6Z+q0n9qpcnIVLQsK4NAJ4kolcNcefhISei6YH/Yzw==",
                UserName = "user",
                RoleId = role1.Id,
            },
            new User
            {
                Id = 2,
                Email = "admin@gmail.com",
                // пароль - string
                PasswordHash = "AQAAAAIAAYagAAAAEIkUamzDMfkTuzbrabohW9DV6Z+q0n9qpcnIVLQsK4NAJ4kolcNcefhISei6YH/Yzw==",
                UserName = "admin",
                RoleId = role2.Id,
            });
    }
}
