using hospitalonlinebooking.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using RestSharp;
using hospitalonlinebooking;

namespace hospitalonlinebooking.Controllers
{
    public class DoctorManagementController : Controller
    {
        private readonly SiteSettings _siteSettings;
        private readonly RestClientHelper _restClientHelper;

        public DoctorManagementController(
            IOptions<SiteSettings> options,
            RestClientHelper restClientHelper)
        {
            _siteSettings = options.Value;
            _restClientHelper = restClientHelper;
        }

        public IActionResult DoctorManagement()
        {
            return View();
        }

        public IActionResult AddDoctor()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> GetDoctors()
        {
            try
            {
                var options = _restClientHelper.CreateRestClientOptions("Doctor/GetDoctors");
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
        public async Task<JsonResult> SaveDoctor([FromBody] DoctorModel obj)
        {
            try
            {
                var options = _restClientHelper.CreateRestClientOptions("Doctor/SaveDoctor");
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
        public async Task<JsonResult> GetDoctorById([FromBody] DoctorModel obj)
        {
            try
            {
                var options = _restClientHelper.CreateRestClientOptions("Doctor/GetDoctorById");
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
        public async Task<JsonResult> UpdateDoctor([FromBody] DoctorModel obj)
        {
            try
            {
                var options = _restClientHelper.CreateRestClientOptions("Doctor/UpdateDoctor");
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
        public async Task<JsonResult> DeleteDoctor([FromBody] DoctorModel obj)
        {
            try
            {
                var options = _restClientHelper.CreateRestClientOptions("Doctor/DeleteDoctor");
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