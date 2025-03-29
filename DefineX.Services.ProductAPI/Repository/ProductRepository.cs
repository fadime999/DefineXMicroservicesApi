using AutoMapper;
using DefineX.Services.ProductAPI.dbcontexts;
using DefineX.Services.ProductAPI.dto;
using DefineX.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DefineX.Services.ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;

        //Constructor Injection 
        public ProductRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<Product> CreateUpdateProduct(Product Product)
        {
            Product product = _mapper.Map<Product, Product>(Product);
            //gelen Product nun içindeki ProductId 0 dan büyük ise güncelleme yapılacak
            if (product.ProductId > 0)
            {
                _db.Products.Update(product);
            }
            else
            {
                //0 dan böyük değilse yeni bir kayıt eklenecek

                _db.Products.Add(product);
            }
            await _db.SaveChangesAsync();
            //kayıt eklendikten sonra databaseden eklenen product objesi geriye produtcDto olarak döndürülür
            return _mapper.Map<Product, Product>(product);
        }

        public async Task<bool> DeleteProduct(int productId)
        {
            try
            {
                Product product = await _db.Products.FirstOrDefaultAsync(u => u.ProductId == productId);
                if (product == null)
                {
                    return false;
                }
                _db.Products.Remove(product); //delete from Product where Id=productId
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<Product> GetProductById(int productId)
        {
            //linq select * from Product where Id=productId
            //{Id:1,Name : Product1}
            Product product = await _db.Products.Where(x => x.ProductId == productId).FirstOrDefaultAsync();
            return _mapper.Map<Product>(product);
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            List<Product> productList = await _db.Products.ToListAsync();
            return _mapper.Map<List<Product>>(productList);
        }
    }
}
