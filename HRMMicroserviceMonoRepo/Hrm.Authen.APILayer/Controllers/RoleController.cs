using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Hrm.Authen.ApplicationCore.Contract.Service;
using Hrm.Authen.ApplicationCore.Model.Request;
using Hrm.Authen.Infrastructure.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hrm.Authen.APILayer.Controller
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleServiceAsync roleServiceAsync;

        public RoleController(IRoleServiceAsync _roleServiceAsync)
        {
            roleServiceAsync = _roleServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await roleServiceAsync.GetAllAsync();
            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var item = await roleServiceAsync.GetByIdAsync(id);
            if (item == null)
            {
                return BadRequest(item);
            }
            return Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Post(RoleRequestModel model)
        {
            if (ModelState.IsValid)
            {
                await roleServiceAsync.InsertAsync(model);
                return Ok();
            }
            return BadRequest(model);
        }

        [HttpPut]
        public async Task<IActionResult> Put(RoleRequestModel model, int id)
        {
            model.Id = id;
            var item = await roleServiceAsync.UpdateAsync(model);
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
            return Ok(await roleServiceAsync.DeleteAsync(id));
        }
    }
}