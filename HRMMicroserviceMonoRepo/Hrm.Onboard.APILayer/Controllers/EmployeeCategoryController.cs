using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Hrm.Onboard.ApplicationCore.Contract.Service;
using Hrm.Onboard.ApplicationCore.Model.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HumanResource.APILayer.Controller
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeCategoryController : ControllerBase
    {
        private readonly IEmployeeCategoryServiceAsync employeeCategoryServiceAsync;

        public EmployeeCategoryController(IEmployeeCategoryServiceAsync _employeeCategoryServiceAsync)
        {
            employeeCategoryServiceAsync = _employeeCategoryServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await employeeCategoryServiceAsync.GetAllAsync();
            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var item = await employeeCategoryServiceAsync.GetByIdAsync(id);
            if (item == null)
            {
                return BadRequest(item);
            }
            return Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Post(EmployeeCategoryRequestModel model)
        {
            if (ModelState.IsValid)
            {
                await employeeCategoryServiceAsync.InsertAsync(model);
                return Ok();
            }
            return BadRequest(model);
        }

        [HttpPut]
        public async Task<IActionResult> Put(EmployeeCategoryRequestModel model, int id)
        {
            model.Id = id;
            var item = await employeeCategoryServiceAsync.UpdateAsync(model);
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
            return Ok(await employeeCategoryServiceAsync.DeleteAsync(id));
        }
    }
}