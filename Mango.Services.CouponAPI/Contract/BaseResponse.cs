namespace Mango.Services.CouponAPI.Contract
{
    public class BaseResponse
    {
        public string Error { get; set; } = string.Empty;
        public bool IsSuccess { get; set; } = true;
        public string Message { get; set; } = "";
    }
}
