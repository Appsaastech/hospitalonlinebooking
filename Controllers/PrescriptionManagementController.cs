using hospitalonlinebooking.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using RestSharp;

namespace hospitalonlinebooking.Controllers
{
    public class PrescriptionManagementController : Controller
    {
        private readonly SiteSettings _siteSettings;
        private readonly RestClientHelper _restClientHelper;

        public PrescriptionManagementController(
            IOptions<SiteSettings> options,
            RestClientHelper restClientHelper)
        {
            _siteSettings = options.Value;
            _restClientHelper = restClientHelper;
        }

        public IActionResult PrescriptionManagement()
        {
            return View();
        }

        // Get Booking Numbers
        [HttpPost]
        public async Task<JsonResult> GetBookingNumbers()
        {
            try
            {
                var options = _restClientHelper.CreateRestClientOptions("Prescription/GetBookingNumbers");
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

        // Get Booking Details
        [HttpPost]
        public async Task<JsonResult> GetBookingDetails([FromBody] BookingModel obj)
        {
            try
            {
                var options = _restClientHelper.CreateRestClientOptions("Prescription/GetBookingDetails");
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

        // Get Prescriptions
        [HttpPost]
        public async Task<JsonResult> GetPrescriptions([FromBody] BookingModel obj)
        {
            try
            {
                var options = _restClientHelper.CreateRestClientOptions("Prescription/GetPrescriptions");
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

        // Get Prescription By Id
        [HttpPost]
        public async Task<JsonResult> GetPrescriptionById([FromBody] PrescriptionModel obj)
        {
            try
            {
                var options = _restClientHelper.CreateRestClientOptions("Prescription/GetPrescriptionById");
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

        // Save Prescription
        [HttpPost]
        public async Task<JsonResult> SavePrescription([FromBody] PrescriptionModel obj)
        {
            try
            {
                var options = _restClientHelper.CreateRestClientOptions("Prescription/SavePrescription");
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

        // Update Prescription
        [HttpPost]
        public async Task<JsonResult> UpdatePrescription([FromBody] PrescriptionModel obj)
        {
            try
            {
                var options = _restClientHelper.CreateRestClientOptions("Prescription/UpdatePrescription");
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

        // Delete Prescription
        [HttpPost]
        public async Task<JsonResult> DeletePrescription([FromBody] PrescriptionModel obj)
        {
            try
            {
                var options = _restClientHelper.CreateRestClientOptions("Prescription/DeletePrescription");
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