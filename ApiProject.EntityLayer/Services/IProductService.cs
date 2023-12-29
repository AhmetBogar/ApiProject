using ApiProject.EntityLayer.DTOs;
using ApiProject.EntityLayer.Models;

namespace ApiProject.EntityLayer.Services
{
    public interface IProductService : IService<Product>
    {
        Task<CustomResponseDto<List<ProductWithCategoryDto>>> GetProductWithCategory();
    }
}
