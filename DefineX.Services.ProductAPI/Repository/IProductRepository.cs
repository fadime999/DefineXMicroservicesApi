using DefineX.Services.ProductAPI.dto;
using DefineX.Services.ProductAPI.Models;

namespace DefineX.Services.ProductAPI.Repository
{
    public interface IProductRepository
    {

        //crud  create read update delete  
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProductById(int productId);
        Task<Product> CreateUpdateProduct(Product Product);
        Task<bool> DeleteProduct(int productId);
    }
}
