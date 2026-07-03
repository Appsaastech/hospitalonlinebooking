using hospitalonlinebooking.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using RestSharp;

namespace hospitalonlinebooking.Controllers
{
    public class AdminAppointmentController : Controller
    {
        private readonly SiteSettings _siteSettings;
        private readonly RestClientHelper _restClientHelper;

        public AdminAppointmentController(
            IOptions<SiteSettings> options,
            RestClientHelper restClientHelper)
        {
            _siteSettings = options.Value;
            _restClientHelper = restClientHelper;
        }

        public IActionResult PublicAppointment()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> GetPatientByRegNo(
            [FromBody] PublicAppointmentModel obj)
        {
            try
            {
                var options = _restClientHelper.CreateRestClientOptions(
                    "PublicAppointment/GetPatientByRegNo");

                var client = new RestClient(options);

                var request = _restClientHelper.CreateRestRequest(new
                {
                    RegNo = obj.PatientRegistrationNo
                },
            "");


                var response = await client.PostAsync<ApiResponse>(request);

                return Json(response);
            }
            catch (Exception ex)
            {
                return Json(RestClientHelper.CreateErrorResponse(ex));
            }
        }

        [HttpPost]
        public async Task<JsonResult> RegisterPatient(
           [FromBody] AdminAppointmentModel obj)
        {
            try
            {
                var options = _restClientHelper.CreateRestClientOptions(
                    "AdminAppointment/RegisterPatient");

                var client = new RestClient(options);

                var request = _restClientHelper.CreateRestRequest(new
                {
                    obj.PatientName,
                    obj.PhoneNumber
                }, "");

                var response = await client.PostAsync<ApiResponse>(request);

                return Json(response);
            }
            catch (Exception ex)
            {
                return Json(RestClientHelper.CreateErrorResponse(ex));
            }
        }


        [HttpPost]
        public async Task<JsonResult> GetDepartments()
        {
            try
            {
                var options = _restClientHelper.CreateRestClientOptions(
                    "PublicAppointment/GetDepartments");

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
        public async Task<JsonResult> GetDoctorsByDepartment(
            [FromBody] PublicAppointmentModel obj)
        {
            try
            {
                var options = _restClientHelper.CreateRestClientOptions(
                    "PublicAppointment/GetDoctorsByDepartment");

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
        public async Task<JsonResult> GetDoctorSchedules(
            [FromBody] PublicAppointmentModel obj)
        {
            try
            {
                var options = _restClientHelper.CreateRestClientOptions(
                    "PublicAppointment/GetDoctorSchedules");

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
        public async Task<JsonResult> GetScheduleTimings(
            [FromBody] PublicAppointmentModel obj)
        {
            try
            {
                var options = _restClientHelper.CreateRestClientOptions(
                    "PublicAppointment/GetScheduleTimings");

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