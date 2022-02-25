using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Stock.Core.Model
{
    public class Variant 
    {
      
        public int VariantId { get; set; }
        public string Name { get; set; }
        public string VariantCode { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
