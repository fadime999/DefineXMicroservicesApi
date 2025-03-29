using AutoMapper;
using DefineX.Services.CouponAPI.Models;
using DefineX.Services.CouponAPI.Models.dto;

namespace DefineX.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>().ReverseMap();

            });

            return mappingConfig;
        }
    }
}
