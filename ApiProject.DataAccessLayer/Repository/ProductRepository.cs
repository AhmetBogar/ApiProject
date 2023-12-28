using ApiProject.EntityLayer.Models;
using ApiProject.EntityLayer.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ApiProject.DataAccessLayer.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Product>> GetProductsWithCategory()
        {
            return await _context.Products.Include(x => x.Category).ToListAsync();
        }
    }
}
