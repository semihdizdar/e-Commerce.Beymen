using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stock.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stock.Repository.Configurations.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product {ProductId=  1, Name = "Iphone 12", ProductCode = "IPHONE12", MetaDescription = "Iphone 12 CellPhone", AdminComment = "Stok var", CreatedDate = DateTime.UtcNow });
            builder.HasData(new Product {ProductId = 2,Name = "Iphone 13", ProductCode = "IPHONE13", MetaDescription = "Iphone 13 CellPhone", AdminComment = "Stok var", CreatedDate = DateTime.UtcNow });
        }
    }
}
