﻿using ApiProject.EntityLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.DataAccessLayer.Configurations
{

    //Db'ye gönderilecek entitylerin manuel olarak hazırlanmış hali. Örnek olarak yazıldı.

    internal class ProductFeatureConfiguration : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasKey(x=> x.Id);
            builder.Property(x=>x.Id).UseIdentityColumn();
            builder.HasOne(x=>x.Product).WithOne(x=>x.ProductFeature).HasForeignKey<ProductFeature>(x=>x.ProductId);
        }
    }
}
