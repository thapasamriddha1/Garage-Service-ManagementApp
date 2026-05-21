
using Microsoft.EntityFrameworkCore;
using garage_api.Models;

namespace garage_api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Vehicle> Vehicles { get; set; }
}
