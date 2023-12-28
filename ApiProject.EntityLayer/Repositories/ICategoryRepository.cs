using ApiProject.EntityLayer.Models;

namespace ApiProject.EntityLayer.Repositories
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Task<Category> GetSingleCategoryByIdWtihProductsAsync(int categoryId);
    }
}
