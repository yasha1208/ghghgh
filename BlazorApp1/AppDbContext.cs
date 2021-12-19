namespace BlazorApp1;
using Microsoft.EntityFrameworkCore;
public class AppDbContext : DbContext
{
    public DbSet<Product> Product => Set<Product>();

    public AppDbContext(
        DbContextOptions<AppDbContext> options) 
        : base(options)
    {
    }
}