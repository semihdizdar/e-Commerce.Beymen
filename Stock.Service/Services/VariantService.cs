using Stock.Core.Model;
using Stock.Core.Repositories;
using Stock.Core.Services;
using Stock.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Service.Services
{
    public class VariantService<T> : IVariantService<Variant> where T : class
    {
        private readonly IVariantRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public VariantService(IUnitOfWork unitOfWork,IVariantRepository repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

     
        public async Task<IEnumerable<Variant>> GetVariantByProductIdAsync(int productId)
        {
            return await _repository.GetVariantByProductId(productId); 
        }

        public async Task<Variant> GetVariantByVariantCode(string variantCode)
        {
            return await _repository.GetVariantByVariantCode(variantCode);
        }
    }
}
