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
    public class StockInfoService<T> :  IStockService<StockInfo> where T : class
    {
        private readonly IStockRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IVariantRepository _variantRepository;
        private readonly IVariantService<Variant> _variantService;

        public StockInfoService(IUnitOfWork unitOfWork, IStockRepository repository, IVariantRepository variantRepository, IVariantService<Variant> variantService)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
            _variantRepository = variantRepository;
            _variantService = variantService;
        }

        public async Task<StockInfo> GetAllByVariantCodeAsync(string variantCode)
        {
            Variant variant = new Variant();
            variant = await _variantRepository.GetVariantByVariantCode(variantCode);
            return await _repository.GetAllByVariantCodeAsync(variant.VariantId,variant.ProductId);
        }

        public async Task<List<StockInfo>> GetQuantityByProductId(int productId)
        {
          

            return await _repository.GetQuantityByVariantId(productId);
        }

        

   
    }
}
