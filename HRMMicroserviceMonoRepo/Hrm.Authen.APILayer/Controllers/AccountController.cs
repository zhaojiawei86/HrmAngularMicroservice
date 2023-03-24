using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Hrm.Authen.ApplicationCore.Contract.Service;
using Hrm.Authen.ApplicationCore.Model.Request;
using JwtAuthenticationManager;
using JwtAuthenticationManager.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hrm.Authen.APILayer.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountServiceAsync accountServiceAsync;
        private readonly JwtTokenHandler jwtTokenHandler;

        public AccountController(IAccountServiceAsync _accountServiceAsync, JwtTokenHandler _jwtTokenHandler)
        {
            accountServiceAsync = _accountServiceAsync;
            jwtTokenHandler = _jwtTokenHandler;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await accountServiceAsync.GetAllAsync();
            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var item = await accountServiceAsync.GetByIdAsync(id);
            if (item == null)
            {
                return BadRequest(item);
            }
            return Ok(item);
        }

        [HttpPost]
        public ActionResult<AuthenticationResponseModel> Login(AuthenticationRequestModel model)
        {
            var response = jwtTokenHandler.GenerateJwtToken(model);
            if (response == null)
            {
                return Unauthorized();
            }
            return response;
        }
        /*
        public async Task<IActionResult> Post(AccountRequestModel model)
        {
            if (ModelState.IsValid)
            {
                await accountServiceAsync.InsertAsync(model);
                return Ok();
            }
            return BadRequest(model);
        }
        */

        [HttpPut]
        public async Task<IActionResult> Put(AccountRequestModel model, int id)
        {
            model.Id = id;
            var item = await accountServiceAsync.UpdateAsync(model);
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
            return Ok(await accountServiceAsync.DeleteAsync(id));
        }
    }
}