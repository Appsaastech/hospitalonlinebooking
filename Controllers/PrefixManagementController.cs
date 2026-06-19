using hospitalonlinebooking.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using RestSharp;
using hospitalonlinebooking;

namespace hospitalonlinebooking.Controllers
{
    public class PrefixManagementController : Controller
    {
        private readonly SiteSettings _siteSettings;
        private readonly RestClientHelper _restClientHelper;

        public PrefixManagementController(
            IOptions<SiteSettings> options,
            RestClientHelper restClientHelper)
        {
            _siteSettings = options.Value;
            _restClientHelper = restClientHelper;
        }

        public IActionResult PrefixManagement()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> GetPrefixes()
        {
            try
            {
                var options = _restClientHelper.CreateRestClientOptions("Prefix/GetPrefixes");
                var client = new RestClient(options);

                var request = _restClientHelper.CreateRestRequest(null, "");

                var response = await client.PostAsync<ApiResponse>(request);

                return Json(response);
            }
            catch (Exception ex)
            {
                return Json(RestClientHelper.CreateErrorResponse(ex));
            }
        }

        [HttpPost]
        public async Task<JsonResult> GetPrefixById([FromBody] PrefixModel obj)
        {
            try
            {
                var options = _restClientHelper.CreateRestClientOptions("Prefix/GetPrefixById");
                var client = new RestClient(options);

                var request = _restClientHelper.CreateRestRequest(obj, "");

                var response = await client.PostAsync<ApiResponse>(request);

                return Json(response);
            }
            catch (Exception ex)
            {
                return Json(RestClientHelper.CreateErrorResponse(ex));
            }
        }

        [HttpPost]
        public async Task<JsonResult> UpdatePrefix([FromBody] PrefixModel obj)
        {
            try
            {
                var options = _restClientHelper.CreateRestClientOptions("Prefix/UpdatePrefix");
                var client = new RestClient(options);

                var request = _restClientHelper.CreateRestRequest(obj, "");

                var response = await client.PostAsync<ApiResponse>(request);

                return Json(response);
            }
            catch (Exception ex)
            {
                return Json(RestClientHelper.CreateErrorResponse(ex));
            }
        }
    }
}
