using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcomDotNet.Entities.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p=>p.Id).IsRequired() ;
            builder.Property(p=>p.name).IsRequired().HasMaxLength(20) ;
            builder.Property(p=>p.description).IsRequired().HasMaxLength(100) ;
            builder.Property(p=>p.price).IsRequired() ;
            builder.Property(p=>p.imageUrl).IsRequired() ;
            builder.Property(p=>p.imageUrl).IsRequired() ;
            builder.HasOne(b=>b.productBrand).WithMany()
                .HasForeignKey(p=>p.ProductBrandId) ;
            builder.HasOne(b=>b.productType).WithMany()
                .HasForeignKey(p=>p.ProductTypeId) ;
             

        }
    }
}