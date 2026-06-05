using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using RestSharp;
using hospitalonlinebooking.Models;

namespace hospitalonlinebooking
{
    public class RestClientHelper : Controller
    {
        private readonly SiteSettings _siteSettings;

        public RestClientHelper(IOptions<SiteSettings> options)
        {
            _siteSettings = options.Value;
        }

        public RestClientOptions CreateRestClientOptions(string apiurl)
        {
            string baseurl = _siteSettings?.BaseUrl ?? "";

            Uri uriobj = new(new Uri(baseurl), apiurl);

            return new RestClientOptions(uriobj)
            {
                ThrowOnAnyError = true,
                Timeout = TimeSpan.FromSeconds(10)
            };
        }

        public RestRequest CreateRestRequest(object? requestBody, string tokenvalue)
        {
            var request = new RestRequest();

            if (requestBody != null)
            {
                request.AddJsonBody(requestBody);
            }

            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Authorization", "Bearer " + tokenvalue);

            return request;
        }

        public static ApiResponse CreateErrorResponse(Exception ex)
        {
            return new ApiResponse(
                ex is HttpRequestException ? 401 : 500,
                ex.Message
            );
        }
    }
}