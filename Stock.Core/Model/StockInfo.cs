using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Stock.Core.Model
{
    public class StockInfo 
    {
        public int StockId { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int VariantId { get; set; }
        public Variant Variant { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
