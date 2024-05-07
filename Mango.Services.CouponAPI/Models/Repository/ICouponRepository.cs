namespace Mango.Services.CouponAPI.Models.Repository
{
    public interface ICouponRepository
    {
        Task<List<Coupon>> GetAll();
        Task<Coupon> Create(Coupon coupon);
        Task<Coupon> Update(int id, Coupon coupon);
        Task<bool> Delete(int id);
        Task<Coupon> GetById(int id);
    }
}
