using System.Text.Json;
using DefineX.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace DefineX.Services.ProductAPI.dbcontexts
{
    public class ProductSeeder
    {
        public static void SeedData(ApplicationDbContext context, IWebHostEnvironment env)
        {
            if (!context.Products.Any()) // Veritabanı boşsa işlemi yap
            {
                var filePath = Path.Combine(env.WebRootPath,"products.json");

                if (File.Exists(filePath))
                {
                    var jsonData = File.ReadAllText(filePath);
                    var products = JsonConvert.DeserializeObject<List<Product>>(jsonData);
                    Console.WriteLine(products);
                    if (products == null || !products.Any())
                    {
                        throw new Exception("JSON verisi deserialize edilemedi veya boş.");
                    }

                    foreach (var product in products)
                    {
                        context.Products.Add(product);

                        if (product.Images != null)
                        {
                            context.Images.AddRange(product.Images);
                        }

                        if (product.Variants != null)
                        {
                            context.Variants.AddRange(product.Variants);
                        }
                        
                     
                    }  
                    context.SaveChanges();
                    Console.WriteLine("Ürünler başarıyla kaydedildi!");
                }
            }
        }
    }
}
