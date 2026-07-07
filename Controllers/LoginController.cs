using hospitalonlinebooking.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using RestSharp;

namespace hospitalonlinebooking.Controllers
{
    public class LoginController : Controller
    {
        private readonly SiteSettings _siteSettings;
        private readonly RestClientHelper _restClientHelper;

        public LoginController(
            IOptions<SiteSettings> options,
            RestClientHelper restClientHelper)
        {
            _siteSettings = options.Value;
            _restClientHelper = restClientHelper;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> Login([FromBody] LoginModel obj)
        {
            try
            {
                var options = _restClientHelper.CreateRestClientOptions("Auth/login");
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