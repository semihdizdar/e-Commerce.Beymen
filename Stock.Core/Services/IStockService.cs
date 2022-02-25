using Stock.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Core.Services
{
    public interface IStockService<T> where T : class
    {
        Task<T> GetAllByVariantCodeAsync(string variantCode);

        Task<List<T>> GetQuantityByProductId(int productId);
    }
}
