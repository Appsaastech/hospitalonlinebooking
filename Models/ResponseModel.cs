using System.Net;

namespace hospitalonlinebooking.Models
{
    public class ResponseModel<T> where T : class
    {
        public HttpStatusCode? ResponseCode { get; set; }
        public string? ResponseMessage { get; set; }
        public T? ResponseData { get; set; }
    }
    public class ResponseDataModel<T> where T : class
    {
        public HttpStatusCode Status { get; set; }
        public T? Response { get; set; }
        public string? Message { get; set; }
        public ErrorResponse? ErrorMessage { get; set; }
    }

    public class ErrorResponse
    {
        public string? Code { get; set; }
        public string? Message { get; set; }
    }
}
