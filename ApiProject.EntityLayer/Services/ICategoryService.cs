using ApiProject.EntityLayer.DTOs;
using ApiProject.EntityLayer.Models;

namespace ApiProject.EntityLayer.Services
{
    public interface ICategoryService : IService<Category>
    {
        public Task<CustomResponseDto<CategoryWithProductsDto>> GetSingleCategoryByIdWithProductAsync(int categoryId);
    }
}
