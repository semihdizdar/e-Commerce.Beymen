using Stock.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Core.Repositories
{
    public interface IStockRepository
    {
        Task<StockInfo> GetAllByVariantCodeAsync(int variantId,int productId);

        Task<List<StockInfo>> GetQuantityByVariantId(int productId);
    }
}
