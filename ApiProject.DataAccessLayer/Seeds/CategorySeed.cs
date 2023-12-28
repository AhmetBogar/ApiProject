using ApiProject.EntityLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiProject.DataAccessLayer.Seeds
{
    internal class CategorySeed : IEntityTypeConfiguration<Category>
    {

        //Database oluşturulduğunda içerisinde aşağıdaki veriler gelecek şekilde oluşması için;
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id = 1, Name = "Kalemler" },
                new Category { Id = 2, Name = "Kitaplar" },
                new Category { Id = 3, Name = "Defterler" });
        }
    }
}
