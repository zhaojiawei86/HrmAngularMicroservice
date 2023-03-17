using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Hrm.Recruitment.APILayer.Model;
using Hrm.Recruitment.ApplicationCore.Contract.Service;
using Hrm.Recruitment.ApplicationCore.Model;
using Hrm.Recruitment.ApplicationCore.Model.Request;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hrm.Recruitment.APILayer.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        private readonly ICandidateServiceAsync candidateServiceAsync;
        private readonly IBlobServiceAsync blobServiceAsync;

        public CandidateController(ICandidateServiceAsync _candidateServiceAsync,
                                    IBlobServiceAsync _blobServiceAsync)
        {
            candidateServiceAsync = _candidateServiceAsync;
            blobServiceAsync = _blobServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await candidateServiceAsync.GetAllAsync();
            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var item = await candidateServiceAsync.GetByIdAsync(id);
            if (item == null)
            {
                return BadRequest(item);
            }
            return Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CandidateRequestModel model)
        {
            if (ModelState.IsValid)
            {
                await candidateServiceAsync.InsertAsync(model);
                return Ok();
            }
            return BadRequest(model);
        }

        [HttpPut]
        public async Task<IActionResult> Put(CandidateRequestModel model, int id)
        {
            model.Id = id;
            var item = await candidateServiceAsync.UpdateAsync(model);
            if (item == 0)
            {
                return BadRequest(item);
            }
            return Ok(item);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            //var item = await candidateServiceAsync.GetByIdAsync(id);
            //if (item == null)
            //{
            //    return BadRequest(item);
            //}
            //await candidateServiceAsync.DeleteAsync(id);
            //return Ok(item);
            return Ok(await candidateServiceAsync.DeleteAsync(id));
        }

        [HttpPost("resume")]
        public async Task<IActionResult> UploadResume(BlobModel blobModel)
        {
            var result = await blobServiceAsync.UploadFileAsync(blobModel.FilePath, blobModel.FileName);
            return Ok(result);
        }

        [HttpDelete("deleteResume")]
        public async Task<IActionResult> DeleteResume(string fileName)
        {
            try {
                await blobServiceAsync.DeleteFileAsync(fileName);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            
        }

        [HttpGet("download")]
        public async Task<IActionResult> GetResume(string path)
        {
            var data = await blobServiceAsync.GetFileAsync(path);
            return File(data.Content, data.ContentType);
        }
    }
}