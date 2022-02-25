using Stock.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Core.Repositories
{
    public interface IVariantRepository
    {
        Task<Variant> GetVariantByVariantCode(string variantCode);

        Task<IEnumerable<Variant>> GetVariantByProductId(int productId);
    }
}
