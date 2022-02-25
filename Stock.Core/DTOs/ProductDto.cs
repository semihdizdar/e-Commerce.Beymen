using System;
using System.Collections.Generic;
using System.Text;

namespace Stock.Core.DTOs
{
    public class ProductDto 
    {
        

        public DateTime CreatedDate { get; set; }

        public string Name { get; set; }

  
        public string ProductCode { get; set; }

    
        public string MetaDescription { get; set; }

     
        public string AdminComment { get; set; }
    }
}
