namespace Mango.Services.CouponAPI.Contract
{
    public class CouponRsp<T> : BaseResponse
    {
        public T? Result { get; set; }
    }
}
