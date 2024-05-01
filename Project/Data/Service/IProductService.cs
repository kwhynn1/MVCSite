using Project.Models;

namespace Project.Data.Service
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProducts();
        Task <Product> GetProductByIdAsync(int ID);
        Task AddAsync(Product product);
        Task <Product> UpdateAsync(int id, Product product);
        Task DeleteAsync(int id);

    }
}
