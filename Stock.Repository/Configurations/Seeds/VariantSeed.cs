using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stock.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stock.Repository.Configurations.Seeds
{
    internal class VariantSeed : IEntityTypeConfiguration<Variant>
    {
        public void Configure(EntityTypeBuilder<Variant> builder)
       {
            builder.HasData(new Variant {VariantId = 1, ProductId = 1, VariantCode = "1000000851090", Name = "Rose - 128", CreatedDate = DateTime.UtcNow });
            builder.HasData(new Variant {VariantId = 2, ProductId = 1, VariantCode = "1000000851091", Name = "Rose - 64" , CreatedDate = DateTime.UtcNow });
            builder.HasData(new Variant {VariantId = 3, ProductId = 1, VariantCode  = "1000000851092", Name = "Gold - 64" , CreatedDate = DateTime.UtcNow });
            builder.HasData(new Variant {VariantId = 4, ProductId = 2, VariantCode = "1000000851093", Name = "Gold - 128", CreatedDate = DateTime.UtcNow });
        }
    }
}
