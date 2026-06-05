namespace hospitalonlinebooking.Models
{
    public class ApiResponse
    {
        public int statuscode { get; set; }
        public object? responsedata { get; set; }

        public ApiResponse()
        {
        }

        public ApiResponse(int statusCode, object? responseData = null)
        {
            statuscode = statusCode;
            responsedata = responseData;
        }
    }
}