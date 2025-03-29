using AutoMapper;
using DefineX.Services.ProductAPI.dto;
using DefineX.Services.ProductAPI.Models;

namespace DefineX.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Product, Product>();
                config.CreateMap<Product, Product>();
            });

            return mappingConfig;
        }
    }
}
