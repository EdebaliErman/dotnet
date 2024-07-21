using Microsoft.EntityFrameworkCore;

namespace ProductApi.Models
{

    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData( new Product { ProductId = 1, ProductName = "IPhone 13", ProductPrice = 50000, ProductStatus = false });
            modelBuilder.Entity<Product>().HasData( new Product { ProductId = 2, ProductName = "IPhone 14", ProductPrice = 60000, ProductStatus = true });
            modelBuilder.Entity<Product>().HasData( new Product { ProductId = 3, ProductName = "IPhone 15", ProductPrice = 70000, ProductStatus = true });
            modelBuilder.Entity<Product>().HasData( new Product { ProductId = 4, ProductName = "IPhone 16", ProductPrice = 80000, ProductStatus = true });
        }
        public DbSet<Product> Products { get; set; }
    }
}
