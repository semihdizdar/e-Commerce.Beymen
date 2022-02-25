using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Stock.Core.Model
{
    public class Product 
    {

        /// <summary>
        /// Gets or sets the Product ID
        /// </summary>
        /// 
        
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the CreatedDate
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the UpdatedDate
        /// </summary>
        public DateTime UpdatedDate { get; set; }

        /// <summary>
        /// Gets or sets the Product Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the ProductCode
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// Gets or sets the MetaDescription
        /// </summary>
        public string MetaDescription { get; set; }

        /// <summary>
        /// Gets or sets the AdminComment
        /// </summary>
        public string AdminComment { get; set; }

        public ICollection<StockInfo> Stocks { get; set; }
        public ICollection<Variant> Variants { get; set; }

    }
}
