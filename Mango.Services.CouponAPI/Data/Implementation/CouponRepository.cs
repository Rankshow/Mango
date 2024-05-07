using Mango.Services.CouponAPI.Models;
using Mango.Services.CouponAPI.Models.Repository;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.CouponAPI.Data.Implementation
{
    public class CouponRepository : ICouponRepository
    {
        private readonly AppDbContext _appDbContext;
        public CouponRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Coupon> Create(Coupon coupon)
        {
            _appDbContext.Coupons.Add(coupon);
            _appDbContext.SaveChanges();
            return await Task.FromResult(coupon);
        }

        public async Task<bool> Delete(int id)
        {
            var deleteCoupon =  await _appDbContext
                .Coupons
                .Where(s => s.CouponId == id)
                .FirstOrDefaultAsync();
            
             if(deleteCoupon != null)
             {
                 _appDbContext.Coupons.Remove(deleteCoupon);
                await _appDbContext.SaveChangesAsync();
             }

             return true;
        }

        public async Task<List<Coupon>> GetAll()
        {
            return await Task.FromResult(_appDbContext.Coupons.ToList());
        }
        public async Task<Coupon> GetById(int id)
        {
            var getId = await _appDbContext.Coupons.Where(s => s.CouponId == id).FirstOrDefaultAsync();
            _appDbContext.SaveChanges();
            return getId ?? new Coupon();
        }

        public async Task<Coupon> Update(int id, Coupon coupon)
        {
            var update = _appDbContext.Coupons.Where(s => s.CouponId == id).FirstOrDefault();
             await _appDbContext.Coupons.AddRangeAsync(update);
            _appDbContext.SaveChanges();
            return await Task.FromResult(update);
        }
    }
}
