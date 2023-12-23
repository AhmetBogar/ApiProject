using ApiProject.EntityLayer.Models;
using ApiProject.EntityLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.DataAccessLayer.Repository
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Category> GetSingleCategoryByIdWtihProductsAsync(int categoryId)
        {
            return await _context.Categories.Include(x=>x.Products).Where(x=>x.Id == categoryId).SingleOrDefaultAsync();
        }
    }
}
