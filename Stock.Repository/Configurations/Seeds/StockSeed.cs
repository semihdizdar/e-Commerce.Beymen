using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stock.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stock.Repository.Configurations.Seeds
{
    internal class StockSeed : IEntityTypeConfiguration<Stock.Core.Model.StockInfo>
    {
        public void Configure(EntityTypeBuilder<Core.Model.StockInfo> builder)
        {
            builder.HasData(new StockInfo {StockId = 1, ProductId = 1, VariantId = 1, Quantity = 30, CreatedDate = DateTime.UtcNow });
            builder.HasData(new StockInfo {StockId = 2, ProductId = 1, VariantId = 2, Quantity = 40, CreatedDate = DateTime.UtcNow });
            builder.HasData(new StockInfo {StockId = 3, ProductId = 1, VariantId = 3, Quantity = 60, CreatedDate = DateTime.UtcNow });
            builder.HasData(new StockInfo {StockId = 4, ProductId = 2, VariantId = 4, Quantity = 70, CreatedDate = DateTime.UtcNow });

        }
    }
}
