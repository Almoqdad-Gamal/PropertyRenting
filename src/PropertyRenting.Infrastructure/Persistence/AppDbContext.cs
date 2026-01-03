using Microsoft.EntityFrameworkCore;
using PropertyRenting.Domain.Entities;

namespace PropertyRenting.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<User> Users => Set<User>();
    }
}