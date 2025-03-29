using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DefineX.Services.ProductAPI.Models
{
    public class Product
    {
        [Key]
        [JsonPropertyName("id")]
        public int ProductId { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }
        public string? Type { get; set; }
        public string Brand { get; set; }
        public List<string>? Collection { get; set; }
        public string? Category { get; set; }
        public double  Price { get; set; }
        public bool Hot { get; set; }
        public string Discount { get; set; }
        public int Stock { get; set; }
        public bool New { get; set; }
        public int? Rating { get; set; }
        public List<string>? Tags { get; set; }

        public List<Variant> Variants { get; set; }
        public List<Image> Images { get; set; }
    }

    public class Variant
    {
        [Key]
        public int VariantId { get; set; }
        public int Id { get; set; }
        public string? Sku { get; set; }
        public string? Size { get; set; }
        public string? Color { get; set; }
        public int ImageId { get; set; }
    }

    public class Image
    {
        [Key]
        public int ImageId { get; set; }
        public int Id { get; set; }
        public string Alt { get; set; }
        public string? Src { get; set; }
        public List<int>? VariantId { get; set; }
    }
}
