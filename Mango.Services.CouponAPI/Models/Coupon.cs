using System.ComponentModel.DataAnnotations;

namespace Mango.Services.CouponAPI.Models
{
    public class Coupon
    {
        public int CouponId { get; set; }       
        public string CouponCode { get; set; } = string.Empty;
        public double DiscountName { get; set; }
        public int MiniAmount { get; set; }
    }
}
