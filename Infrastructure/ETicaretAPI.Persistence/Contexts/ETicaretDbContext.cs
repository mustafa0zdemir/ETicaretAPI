using ETicaretAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ETicaretAPI.Persistence.Contexts;

public class ETicaretDbContext : DbContext
{
    public ETicaretDbContext(DbContextOptions<ETicaretDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Customer> Customers { get; set; }
}