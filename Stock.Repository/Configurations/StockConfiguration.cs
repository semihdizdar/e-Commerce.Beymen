using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stock.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stock.Repository.Configurations
{
    internal class StockConfiguration : IEntityTypeConfiguration<StockInfo>
    {
        public void Configure(EntityTypeBuilder<StockInfo> builder)
        {
            builder.HasKey(x => x.StockId);

            builder.Property(x => x.StockId).UseIdentityColumn();

            builder.Property(x => x.StockId).IsRequired();

            builder
                .HasOne(x => x.Product)
                .WithMany(y => y.Stocks)
                .HasForeignKey(x => x.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(m => m.VariantId)
                .IsRequired();


            builder.Property(m => m.Quantity).HasDefaultValue(0);
            builder.Property(m => m.CreatedDate).HasDefaultValue(DateTime.Now);
            builder.Property(m => m.UpdatedDate).HasDefaultValue("0001.01.01");
            builder.ToTable("StockInfo");




        }
    }
}
