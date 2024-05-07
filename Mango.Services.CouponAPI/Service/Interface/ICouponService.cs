using Mango.Services.CouponAPI.Contract;
using Mango.Services.CouponAPI.Features.Dto;
using Mango.Services.CouponAPI.Features.Dto.Request;

namespace Mango.Services.CouponAPI.Service.Interface
{
    public interface ICouponService
    {
        Task<CouponRsp<CouponDto>> Create(CreateCouponReq createReq);
        Task<CouponRsp<CouponDto>> Update(int id, UpdateCouponReq updateReq);
        Task<CouponRsp<CouponDto>> GetById(int id);
        Task<CouponRsp<bool>> Delete(int id);
        Task<CouponRsp<List<CouponDto>>> GetAll();
    }
}
