using DefineXWeb.Models;

namespace DefineXWeb.Services.IServices
{
    public interface IProductService : IBaseService
    {
        Task<T> GetAllProductsAsync<T>(string token);
        Task<T> GetProductByIdAsync<T>(int id, string token);
        Task<T> CreateProductAsync<T>(Product Product, string token);
        Task<T> UpdateProductAsync<T>(Product Product, string token);
        Task<T> DeleteProductAsync<T>(int id, string token);
    }
}
