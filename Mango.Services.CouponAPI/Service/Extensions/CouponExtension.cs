using Mango.Services.CouponAPI.Features.Dto;
using Mango.Services.CouponAPI.Features.Dto.Request;
using Mango.Services.CouponAPI.Models;

namespace Mango.Services.CouponAPI.Services.Extensions
{
    public static class CouponExtension
    {
        public static Coupon AsEntity(this CreateCouponReq req)
        {
            return new Coupon
            {
                DiscountName = req.DiscountName,
                CouponCode = req.CouponCode,
                MiniAmount = req.MiniAmount
            };
        }

        public static CouponDto AsDto(this Coupon dto)
        {
            return new CouponDto
            {
                DiscountName = dto.DiscountName,
                CouponCode = dto.CouponCode,
                CouponId = dto.CouponId,
                MiniAmount = dto.MiniAmount
            };
        }

        public static List<CouponDto> AsDto(this IEnumerable<Coupon> entities)
        {
            List<CouponDto> couponDtos = new();

            foreach (var entity in entities)
            {
                couponDtos.Add(entity.AsDto());
            }
            return couponDtos;
        }

        public static Coupon AsEntity(this UpdateCouponReq entity)
        {
            return new Coupon
            {
                CouponId = entity.CouponId,
                DiscountName = entity.DiscountName,
                CouponCode = entity.CouponCode,
                MiniAmount = entity.MiniAmount
            };
        }
    }
}
