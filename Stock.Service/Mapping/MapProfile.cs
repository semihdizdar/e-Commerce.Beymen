using AutoMapper;
using Stock.Core.DTOs;
using Stock.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stock.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Variant, VariantDto>().ReverseMap();
            CreateMap<StockInfo, StockInfoDto>().ReverseMap();
            
        }
    }
}
