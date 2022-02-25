using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stock.Core.DTOs;
using Stock.Core.Model;
using Stock.Core.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace Stock.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : CustomBaseController
    {

        private readonly IMapper _mapper;
        private readonly IService<StockInfo> _service;
        private readonly IStockService<StockInfo> _stockService;
        private readonly IVariantService<Variant> _variantService;


        public StockController(IMapper mapper, IService<StockInfo> service, IStockService<StockInfo> stockService, IVariantService<Variant> variantService)
        {
            _mapper = mapper;
            _service = service;
            _stockService = stockService;
            _variantService = variantService;
        }

        [HttpPost]
        public async Task<IActionResult> Save(StockInfoDto stockDto)
        {
            var stockInfo = await _service.AddAsync(_mapper.Map<StockInfo>(stockDto));

            var StockDto = _mapper.Map<StockInfoDto>(stockInfo);

            return CreateActionResult(CustomResponseDto<StockInfoDto>.Success(201, StockDto));
        }

        [HttpGet("{variantCode}")]
        public async Task<IActionResult> GetStocksByVariantCode(string variantCode)
        {

            var stockInfo = await _stockService.GetAllByVariantCodeAsync(variantCode);
            var stockDto = _mapper.Map<StockInfo,StockInfoDto>(stockInfo);

            return Ok(stockDto);
        }

        [HttpGet("{productId}/product")]
        public async Task<IActionResult> GetStockInfoByProductId(int productId)
        {

            var stockInfo = await _stockService.GetQuantityByProductId(productId);

            var stockDto = _mapper.Map<List<StockInfo>, List<StockInfoDto>>(stockInfo);
           

            return Ok(stockDto);
        }




    }
}
