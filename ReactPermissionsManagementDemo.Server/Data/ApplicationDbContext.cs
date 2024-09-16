using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ReactPermissionsManagementDemo.Server.Models;

namespace IdentityApp.Server.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // 添加種子數據
        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Product1", Price = 9.99m },
            new Product { Id = 2, Name = "Product2", Price = 19.99m },
            new Product { Id = 3, Name = "Product3", Price = 29.99m }
        );
    }
}