using hospitalonlinebooking.Models;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using ShopManagement;

namespace hospitalonlinebooking.Controllers
{
    public class DepartmentManagementController : Controller
    {
        private readonly RestClientHelper _restClientHelper;

        public DepartmentManagementController(RestClientHelper restClientHelper)
        {
            _restClientHelper = restClientHelper;
        }

        public IActionResult DepartmentManagement()
        {
            return View();
        }

        public IActionResult AddDepartment()
        {
            return View();
        }

        [HttpGet]
        public async Task<JsonResult> GetDepartments()
        {
            try
            {
                var options = _restClientHelper.CreateRestClientOptions("Department/GetDepartments");

                var client = new RestClient(options);

                var request = _restClientHelper.CreateRestRequest(null, "");

                var response =
                    await client.PostAsync<ResponseDataModel<IEnumerable<DepartmentModel>>>(request);

                return Json(response);
            }
            catch (Exception ex)
            {
                var response = RestClientHelper.CreateErrorResponse(ex);
                return Json(response);
            }
        }

        [HttpPost]
        public async Task<JsonResult> SaveDepartment([FromBody] DepartmentModel obj)
        {
            try
            {
                var options = _restClientHelper.CreateRestClientOptions("Department/SaveDepartment");

                var client = new RestClient(options);

                var request = _restClientHelper.CreateRestRequest(obj, "");

                var response =
                    await client.PostAsync<ResponseDataModel<string>>(request);

                return Json(response);
            }
            catch (Exception ex)
            {
                var response = RestClientHelper.CreateErrorResponse(ex);
                return Json(response);
            }
        }

        [HttpPost]
        public async Task<JsonResult> GetDepartmentById([FromBody] DepartmentModel obj)
        {
            try
            {
                var options = _restClientHelper.CreateRestClientOptions("Department/GetDepartmentById");

                var client = new RestClient(options);

                var request = _restClientHelper.CreateRestRequest(obj, "");

                var response =
                    await client.PostAsync<ResponseDataModel<DepartmentModel>>(request);

                return Json(response);
            }
            catch (Exception ex)
            {
                var response = RestClientHelper.CreateErrorResponse(ex);
                return Json(response);
            }
        }

        [HttpPost]
        public async Task<JsonResult> UpdateDepartment([FromBody] DepartmentModel obj)
        {
            try
            {
                var options = _restClientHelper.CreateRestClientOptions("Department/UpdateDepartment");

                var client = new RestClient(options);

                var request = _restClientHelper.CreateRestRequest(obj, "");

                var response =
                    await client.PostAsync<ResponseDataModel<string>>(request);

                return Json(response);
            }
            catch (Exception ex)
            {
                var response = RestClientHelper.CreateErrorResponse(ex);
                return Json(response);
            }
        }

        [HttpPost]
        public async Task<JsonResult> DeleteDepartment([FromBody] DepartmentModel obj)
        {
            try
            {
                var options = _restClientHelper.CreateRestClientOptions("Department/DeleteDepartment");

                var client = new RestClient(options);

                var request = _restClientHelper.CreateRestRequest(obj, "");

                var response =
                    await client.PostAsync<ResponseDataModel<string>>(request);

                return Json(response);
            }
            catch (Exception ex)
            {
                var response = RestClientHelper.CreateErrorResponse(ex);
                return Json(response);
            }
        }
    }
}