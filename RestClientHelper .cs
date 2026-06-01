
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using RestSharp;
using hospitalonlinebooking.Controllers;
using hospitalonlinebooking.Models;
using System.Net;

namespace ShopManagement
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
            request.AddHeader("Authorization", "Bearer " + tokenvalue ?? "");
            return request;
        }
        public static ResponseDataModel<string> CreateErrorResponse(Exception ex)
        {
            return new ResponseDataModel<string>()
            {
                Status = ex is HttpRequestException httpEx && httpEx.StatusCode == HttpStatusCode.Unauthorized ? HttpStatusCode.Unauthorized : HttpStatusCode.InternalServerError,
                Response = null,
                Message = ex is HttpRequestException ? "Unauthorized" : "Something went wrong",
                ErrorMessage = new ErrorResponse
                {
                    Code = ex is HttpRequestException ? "401" : "500",
                    Message = ex.Message.ToString()
                }
            };
        }
    }
}
