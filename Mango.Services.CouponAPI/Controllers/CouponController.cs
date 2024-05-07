using Mango.Services.CouponAPI.Contract;
using Mango.Services.CouponAPI.Data;
using Mango.Services.CouponAPI.Features.Dto;
using Mango.Services.CouponAPI.Features.Dto.Request;
using Mango.Services.CouponAPI.Models;
using Mango.Services.CouponAPI.Models.Repository;
using Mango.Services.CouponAPI.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.CouponAPI.Controllers
{
    [Route("api/coupons")]
    [ApiController]
    public class CouponController : ControllerBase
    {
        private readonly ICouponRepository _couponRepository;
        public CouponController(ICouponRepository couponRepository)
        {
            _couponRepository = couponRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<BaseResponse>>> GetAllCoupon()
        {
           return Ok(await Task.FromResult(_couponRepository.GetAll()));
        }
        [HttpPost]
        public async Task<ActionResult<CouponDto>> CreateCoupon(Coupon coupon)
        {
            var addCoupon = await _couponRepository.Create(coupon);
            return Ok(addCoupon);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<BaseResponse>> GetById(int id)
        {
           var addId = await _couponRepository.GetById(id);
            return Ok(addId);
        }

        [HttpDelete]
        public async Task<ActionResult<BaseResponse>> Delete(int id)
        {
            var deleteCoupon = await _couponRepository.Delete(id);
            return Ok(deleteCoupon);
        }

        [HttpPut]
        public async Task<ActionResult<BaseResponse>> Update(int id, Coupon coupon)
        {
            var update = await _couponRepository.Update(id, coupon);
            return Ok(update);
        }
    }
}
