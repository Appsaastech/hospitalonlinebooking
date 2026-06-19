using hospitalonlinebooking.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using RestSharp;

namespace hospitalonlinebooking.Controllers
{
    public class PatientManagementController : Controller
    {
        private readonly SiteSettings _siteSettings;
        private readonly RestClientHelper _restClientHelper;

        public PatientManagementController(
            IOptions<SiteSettings> options,
            RestClientHelper restClientHelper)
        {
            _siteSettings = options.Value;
            _restClientHelper = restClientHelper;
        }

        public IActionResult PatientManagement()
        {
            return View();
        }

        public IActionResult AddPatient()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> GetPatients()
        {
            try
            {
                var options = _restClientHelper.CreateRestClientOptions("Patient/GetPatients");
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
        public async Task<JsonResult> GetPatientById([FromBody] PatientModel obj)
        {
            try
            {
                var options = _restClientHelper.CreateRestClientOptions("Patient/GetPatientById");
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
        public async Task<JsonResult> SavePatient([FromBody] PatientModel obj)
        {
            try
            {
                var options = _restClientHelper.CreateRestClientOptions("Patient/SavePatient");
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
        public async Task<JsonResult> UpdatePatient([FromBody] PatientModel obj)
        {
            try
            {
                var options = _restClientHelper.CreateRestClientOptions("Patient/UpdatePatient");
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
        public async Task<JsonResult> DeletePatient([FromBody] PatientModel obj)
        {
            try
            {
                var options = _restClientHelper.CreateRestClientOptions("Patient/DeletePatient");
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