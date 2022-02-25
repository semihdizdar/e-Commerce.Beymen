using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stock.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stock.Repository.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {

            builder
                 .HasKey(m => m.ProductId);

            builder
                .HasIndex(m => m.ProductId).IsUnique();

            builder
                .HasIndex(m => m.ProductCode).IsUnique();

            builder
                .Property(m => m.Name)
                .IsRequired();

            builder
                .ToTable("Products");





        }
    }
}
