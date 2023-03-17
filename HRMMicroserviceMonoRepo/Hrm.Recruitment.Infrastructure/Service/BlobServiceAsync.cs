using System;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Hrm.Recruitment.ApplicationCore.Contract.Service;
using Hrm.Recruitment.ApplicationCore.Model;

namespace Hrm.Recruitment.Infrastructure.Service
{
	public class BlobServiceAsync :IBlobServiceAsync
	{
        private readonly BlobServiceClient blobServiceClient;

        public BlobServiceAsync(BlobServiceClient _blobServiceClient)
		{
            blobServiceClient = _blobServiceClient;
        }

        public Task DeleteFileAsync(string fileName)
        {
            var clientContainer = blobServiceClient.GetBlobContainerClient("resumecontainertest");
            var clientName = clientContainer.GetBlobClient(fileName);
            return clientName.DeleteAsync();
        }

        public async Task<BlobContent> GetFileAsync(string filePath)
        {
            var fileName = new Uri(filePath).Segments.LastOrDefault();
            var clientContainer = blobServiceClient.GetBlobContainerClient("resumecontainertest");
            var clientName = clientContainer.GetBlobClient(fileName);
            if (await clientName.ExistsAsync())
            {
                var download = await clientName.DownloadContentAsync();
                return new BlobContent()
                {
                    Content = download.Value.Content.ToStream(),
                    ContentType = download.Value.Details.ContentType
                };
            }
            else
            {
                return null;
            }
        }

        public async Task<string> UploadFileAsync(string filePath, string fileName)
        {
            var clientContainer = blobServiceClient.GetBlobContainerClient("resumecontainertest");
            var clientName = clientContainer.GetBlobClient(fileName);
            await clientName.UploadAsync(filePath);
            return clientName.Uri.AbsoluteUri;
        }
    }
}

