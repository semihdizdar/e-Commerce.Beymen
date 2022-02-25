using System;
using System.Collections.Generic;
using System.Text;

namespace Stock.Core.DTOs
{
    public class StockRequestModel
    {
        public string VariantCode { get; set; }
        public string ProductCode { get; set; }
        public int Quantity { get; set; }
    }
}
