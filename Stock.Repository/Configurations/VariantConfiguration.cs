using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stock.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stock.Repository.Configurations
{
    internal class VariantConfiguration : IEntityTypeConfiguration<Variant>
    {
        public void Configure(EntityTypeBuilder<Variant> builder)
        {
            builder
            .HasKey(a => a.VariantId);

            builder
                .HasIndex(a => a.VariantId).IsUnique();

            builder
                .Property(m => m.ProductId)
                .IsRequired();

            builder
                .HasOne(m => m.Product)
                .WithMany(a => a.Variants)
                .HasForeignKey(m => m.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .ToTable("Variants");


        }
    }
}
