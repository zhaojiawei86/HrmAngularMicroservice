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
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserRoleController : ControllerBase
    {
        private readonly IUserRoleServiceAsync userRoleServiceAsync;

        public UserRoleController(IUserRoleServiceAsync _userRoleServiceAsync)
        {
            userRoleServiceAsync = _userRoleServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await userRoleServiceAsync.GetAllAsync();
            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var item = await userRoleServiceAsync.GetByIdAsync(id);
            if (item == null)
            {
                return BadRequest(item);
            }
            return Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Post(UserRoleRequestModel model)
        {
            if (ModelState.IsValid)
            {
                await userRoleServiceAsync.InsertAsync(model);
                return Ok();
            }
            return BadRequest(model);
        }

        [HttpPut]
        public async Task<IActionResult> Put(UserRoleRequestModel model, int id)
        {
            model.Id = id;
            var item = await userRoleServiceAsync.UpdateAsync(model);
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
            return Ok(await userRoleServiceAsync.DeleteAsync(id));
        }
    }
}