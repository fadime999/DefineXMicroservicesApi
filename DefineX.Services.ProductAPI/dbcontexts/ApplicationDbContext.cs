using DefineX.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DefineX.Services.ProductAPI.dbcontexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Variant> Variants { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //// Product Seed Data
            //modelBuilder.Entity<Product>().HasData(new Product
            //{
            //    ProductId = -1,
            //    Title = "Black T-Shirt For Woman",
            //    Description = "Vivamus suscipit tortor eget felis porttitor volutpat...",
            //    Type = "fashion",
            //    Brand = "nike",
            //    Collection = ["YENİ GELEN ÜRÜNLER"],
            //    Category = "Women",
            //    Price = 145,
            //    Hot = true,
            //    Discount = "40",
            //    Stock = 5,
            //    New = true,
            //    Rating = 5,
            //    Tags=[
            //    "new",
            //    "s",
            //    "m",
            //    "yellow",
            //    "white",
            //    "pink",
            //    "nike"
            //]
            //});

            //// Variant Seed Data
            //modelBuilder.Entity<Variant>().HasData(
            //    new Variant
            //    {
            //        VariantId = 101,
            //        Id = -1,  // Product ile ilişkilendirme
            //        Sku = "sku1",
            //        Size = "s",
            //        Color = "yellow",
            //        ImageId = 111
            //    }
            //);

            //// Image Seed Data - VariantId Ekledik!
            //modelBuilder.Entity<Image>().HasData(
            //    new Image
            //    {
            //        ImageId = 111,
            //        Id = -1,  // Product ile ilişkilendirme
            //        Alt = "yellow",
            //        Src = "1.png",
            //        VariantId = [
            //            101,
            //            104
            //        ]
            //    }
            //);
        }
    }
}
