using ApiProject.EntityLayer.DTOs;
using ApiProject.EntityLayer.Models;
using ApiProject.EntityLayer.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryWithDtoController : ControllerBase
    {
        private readonly IServiceWithDto<Category,CategoryDto> _categoryServiceWithDto;

        public CategoryWithDtoController(IServiceWithDto<Category, CategoryDto> service)
        {
            _categoryServiceWithDto = service;
        }
    }
}
