using Microsoft.EntityFrameworkCore;
namespace backend.Model;

public class UserContext : DbContext
{
    public UserContext(DbContextOptions<UserContext> options) : base(options)
    {
    }

    public DbSet<User> UserDetails { get; set; } = null!;
}