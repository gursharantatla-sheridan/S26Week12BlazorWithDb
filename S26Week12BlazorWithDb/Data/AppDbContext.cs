using Microsoft.EntityFrameworkCore;
using S26Week12BlazorWithDb.Models;

namespace S26Week12BlazorWithDb.Data
{
    public class AppDbContext : DbContext
    {
        // conn str - REQUIRED
        // constructor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


        // entity sets - REQUIRED
        // DbSet properties
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }


        // data seeding - OPTIONAL
        // override OnModelCreating method
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Electronics" },
                new Category { CategoryId = 2, CategoryName = "Applicances" },
                new Category { CategoryId = 3, CategoryName = "Clothing" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, ProductName = "Laptop", CategoryId = 1 },
                new Product { ProductId = 2, ProductName = "Phone", CategoryId = 1 },
                new Product { ProductId = 3, ProductName = "Tablet", CategoryId = 1 },
                new Product { ProductId = 4, ProductName = "Microwave", CategoryId = 2 },
                new Product { ProductId = 5, ProductName = "Jacket", CategoryId = 3 }
            );
        }
    }
}
