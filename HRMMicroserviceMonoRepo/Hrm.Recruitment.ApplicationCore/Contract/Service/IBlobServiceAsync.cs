using System;
using Azure.Storage.Blobs.Models;
using Hrm.Recruitment.ApplicationCore.Model;

namespace Hrm.Recruitment.ApplicationCore.Contract.Service
{
	public interface IBlobServiceAsync
	{
		Task DeleteFileAsync(string fileName);
		Task<string> UploadFileAsync(string filePath,string fileName);
        Task<BlobContent> GetFileAsync(string fileName);
		

    }  
}

