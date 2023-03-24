using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Hrm.Recruitment.ApplicationCore.Contract.Service;
using Hrm.Recruitment.ApplicationCore.Model.Request;
using Hrm.Recruitment.Infrastructure.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hrm.Recruitment.APILayer.Controller
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class JobCategoryController : ControllerBase
    {
        private readonly IJobCategoryServiceAsync jobCategoryServiceAsync;

        public JobCategoryController(IJobCategoryServiceAsync _jobCategoryServiceAsync)
        {
            jobCategoryServiceAsync = _jobCategoryServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await jobCategoryServiceAsync.GetAllAsync();
            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var item = await jobCategoryServiceAsync.GetByIdAsync(id);
            if (item == null)
            {
                return BadRequest(item);
            }
            return Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Post(JobCategoryRequestModel model)
        {
            if (ModelState.IsValid)
            {
                await jobCategoryServiceAsync.InsertAsync(model);
                return Ok();
            }
            return BadRequest(model);
        }

        [HttpPut]
        public async Task<IActionResult> Put(JobCategoryRequestModel model, int id)
        {
            model.Id = id;
            var item = await jobCategoryServiceAsync.UpdateAsync(model);
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
            return Ok(await jobCategoryServiceAsync.DeleteAsync(id));
        }
    }
}