using ApiProject.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.EntityLayer.Repositories
{
    public interface IProductRepository:IGenericRepository<Product>
    {
        Task <List<Product>> GetProductsWithCategory();
    }
}
