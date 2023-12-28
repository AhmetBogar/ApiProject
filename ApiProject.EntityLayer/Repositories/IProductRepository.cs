using ApiProject.EntityLayer.Models;

namespace ApiProject.EntityLayer.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<List<Product>> GetProductsWithCategory();
    }
}
