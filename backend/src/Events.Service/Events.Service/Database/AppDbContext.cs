using Events.Service.Entities;
using Microsoft.EntityFrameworkCore;

namespace Events.Service.Database;

public sealed class AppDbContext : DbContext
{
    public DbSet<Event> Events => Set<Event>();

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}