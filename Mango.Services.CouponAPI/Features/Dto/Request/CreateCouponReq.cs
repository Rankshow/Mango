namespace Mango.Services.CouponAPI.Features.Dto.Request
{
    public class CreateCouponReq
    {
        //public int CouponId { get; set; }
        public string CouponCode { get; set; } = string.Empty;
        public double DiscountName { get; set; }
        public int MiniAmount { get; set; }
    }
}
