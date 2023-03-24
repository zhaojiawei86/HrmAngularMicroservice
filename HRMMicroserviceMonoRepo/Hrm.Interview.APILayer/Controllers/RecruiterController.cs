using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Hrm.Interview.APILayer.Model;
using Hrm.Interview.ApplicationCore.Contract.Service;
using Hrm.Interview.ApplicationCore.Model.Request;
using Hrm.Interview.Infrastructure.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hrm.Interview.APILayer.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RecruiterController : ControllerBase
    {
        private readonly IConfiguration configuration;
        private readonly IRecruiterServiceAsync recruiterServiceAsync;
        private readonly HttpClient httpClient = new HttpClient();

        public RecruiterController(IConfiguration _configuration,IRecruiterServiceAsync _recruiterServiceAsync)
        {
            configuration = _configuration;
            recruiterServiceAsync = _recruiterServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await recruiterServiceAsync.GetAllAsync();
            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var item = await recruiterServiceAsync.GetByIdAsync(id);
            if (item == null)
            {
                return BadRequest(item);
            }
            return Ok(item);
        }

        [HttpGet]
        [Route("employee")]
        public async Task<IActionResult> GetEmployee()
        {
            httpClient.BaseAddress = new Uri(configuration.GetSection("OnboardApiUrl").Value);
            var employeeResult = await httpClient.GetFromJsonAsync<IEnumerable<EmployeeModel>>(httpClient.BaseAddress + "employee");
            return Ok(employeeResult);
        }

        [HttpPost]
        public async Task<IActionResult> Post(RecruiterRequestModel model)
        {
            if (ModelState.IsValid)
            {
                await recruiterServiceAsync.InsertAsync(model);
                return Ok();
            }
            return BadRequest(model);
        }

        [HttpPut]
        public async Task<IActionResult> Put(RecruiterRequestModel model, int id)
        {
            model.Id = id;
            var item = await recruiterServiceAsync.UpdateAsync(model);
            if (item == 0)
            {
                return BadRequest(item);
            }
            return Ok(item);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await recruiterServiceAsync.DeleteAsync(id));
        }
    }
}
