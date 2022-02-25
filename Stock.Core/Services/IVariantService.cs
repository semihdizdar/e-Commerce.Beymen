using Stock.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Core.Services
{
    public interface IVariantService<T> where T : class
    {
        Task<T> GetVariantByVariantCode(string variantCode);
        Task<IEnumerable<T>> GetVariantByProductIdAsync(int productId);
    }
}
