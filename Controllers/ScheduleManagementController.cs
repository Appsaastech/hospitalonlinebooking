using hospitalonlinebooking.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using RestSharp;
using hospitalonlinebooking;

namespace hospitalonlinebooking.Controllers
{
    public class ScheduleManagementController : Controller
    {
        private readonly SiteSettings _siteSettings;
        private readonly RestClientHelper _restClientHelper;

        public ScheduleManagementController(
            IOptions<SiteSettings> options,
            RestClientHelper restClientHelper)
        {
            _siteSettings = options.Value;
            _restClientHelper = restClientHelper;
        }

        public IActionResult ScheduleList()
        {
            return View();
        }

        public IActionResult AddSchedule()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> GetSchedules()
        {
            try
            {
                var options = _restClientHelper.CreateRestClientOptions("DoctorSchedule/GetSchedules");
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
        public async Task<JsonResult> SaveSchedule([FromBody] DoctorSchedule obj)
        {
            try
            {
                var options = _restClientHelper.CreateRestClientOptions("DoctorSchedule/SaveSchedule");
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