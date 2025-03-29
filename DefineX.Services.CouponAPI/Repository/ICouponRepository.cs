using DefineX.Services.CouponAPI.Models.dto;

namespace DefineX.Services.CouponAPI.Repository
{
    public interface ICouponRepository
    {
        Task<CouponDto> GetCouponByCode(string couponCode);
    }
}
