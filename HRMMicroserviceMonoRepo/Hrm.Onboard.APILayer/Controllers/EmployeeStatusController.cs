using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Hrm.Onboard.ApplicationCore.Contract.Service;
using Hrm.Onboard.ApplicationCore.Model.Request;
using Hrm.Onboard.Infrastructure.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HumanResource.APILayer.Controller
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeStatusController : ControllerBase
    {
        private readonly IEmployeeStatusServiceAsync employeeStatusServiceAsync;

        public EmployeeStatusController(IEmployeeStatusServiceAsync _employeeStatusServiceAsync)
        {
            employeeStatusServiceAsync = _employeeStatusServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await employeeStatusServiceAsync.GetAllAsync();
            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var item = await employeeStatusServiceAsync.GetByIdAsync(id);
            if (item == null)
            {
                return BadRequest(item);
            }
            return Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Post(EmployeeStatusRequestModel model)
        {
            if (ModelState.IsValid)
            {
                await employeeStatusServiceAsync.InsertAsync(model);
                return Ok();
            }
            return BadRequest(model);
        }

        [HttpPut]
        public async Task<IActionResult> Put(EmployeeStatusRequestModel model, int id)
        {
            model.Id = id;
            var item = await employeeStatusServiceAsync.UpdateAsync(model);
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
            return Ok(await employeeStatusServiceAsync.DeleteAsync(id));
        }
    }
}