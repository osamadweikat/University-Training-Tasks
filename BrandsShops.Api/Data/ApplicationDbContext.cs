using BrandsShops.Api.Models;
using Microsoft.EntityFrameworkCore;
using BrandModel = BrandsShops.Api.Models.Brand;
using OrderModel = BrandsShops.Api.Models.Order;
using ProductModel = BrandsShops.Api.Models.Product;

namespace BrandsShops.Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<OrderModel> Orders => Set<OrderModel>();
        public DbSet<ProductModel> Products => Set<ProductModel>();
        public DbSet<BrandModel> Brands => Set<BrandModel>();
        public DbSet<CartItem> CartItems => Set<CartItem>();
        public DbSet<Student> Students => Set<Student>(); 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CartItem>()
                .HasOne(c => c.Product)
                .WithMany()
                .HasForeignKey(c => c.ProductId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
