using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project.Data.Service
{
    public class ProductService : IProductService
    {

        private readonly ApplicationDbContext _context;


        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Product product)
        {
          await  _context.Product.AddAsync(product);
          await  _context.SaveChangesAsync(); 
        }

        public async Task DeleteAsync(int ID)
        {
            var result = await _context.Product.FirstOrDefaultAsync(x => x.ID == ID);
            _context.Product.Remove(result);
            await _context.SaveChangesAsync();

        }

        public async Task <Product> GetProductByIdAsync(int ID)
        {
            var result = await _context.Product.FirstOrDefaultAsync(x => x.ID == ID);
            return result;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            var result = await _context.Product.ToListAsync();
            return result;
        }

        public async Task<Product> UpdateAsync(int id, Product product)
        {
            _context.Update(product);
            await _context.SaveChangesAsync();
            return product;
        }
    }
}
