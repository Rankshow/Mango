using Mango.Services.CouponAPI.Contract;
using Mango.Services.CouponAPI.Features.Dto;
using Mango.Services.CouponAPI.Features.Dto.Request;
using Mango.Services.CouponAPI.Models.Repository;
using Mango.Services.CouponAPI.Service.Interface;
using Mango.Services.CouponAPI.Services.Extensions;

namespace Mango.Services.CouponAPI.Services.Implementation
{
    public class CouponService : ICouponService
    {
        private readonly ICouponRepository _couponRepository;
        public CouponService(ICouponRepository couponRepository)
        {
            _couponRepository = couponRepository;
        }

        public async Task<CouponRsp<CouponDto>> Create(CreateCouponReq createReq)
        {
            var req = createReq.AsEntity();
            await _couponRepository.Create(req);

            return new CouponRsp<CouponDto>
            {
                IsSuccess = true,
                Message = "Completed",
                Error = ""
            }; 
        }

        public async Task<CouponRsp<bool>> Delete(int id)
        {
            var toDelete = await _couponRepository.Delete(id);

            return new CouponRsp<bool>
            {
                IsSuccess = true,
                Message = "Deleted!!!",
                Result = toDelete
            };
        }

        public async Task<CouponRsp<List<CouponDto>>> GetAll()
        {
            await _couponRepository.GetAll();

            return new CouponRsp<List<CouponDto>>
            {
                IsSuccess = true,
                Message = "Completed",
                Error = ""
            };
        }

        public async Task<CouponRsp<CouponDto>> GetById(int id)
        {
            await _couponRepository.GetById(id);
            return new CouponRsp<CouponDto>
            {
                IsSuccess = true,
                Message = "Complete",
                Error = ""
            };    
        }

        public async Task<CouponRsp<CouponDto>> Update(int id, UpdateCouponReq updateReq)
        {
            var req = updateReq.AsEntity();
            await _couponRepository.Update(id, req);
            return new CouponRsp<CouponDto>
            {
                IsSuccess = true,
                Message = "Completed",
                Error = ""
            }; 
        }
    }
}


