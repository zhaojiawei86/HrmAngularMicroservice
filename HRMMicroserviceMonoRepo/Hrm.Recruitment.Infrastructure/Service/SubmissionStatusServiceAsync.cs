using System;
using Hrm.Recruitment.ApplicationCore.Contract.Repository;
using Hrm.Recruitment.ApplicationCore.Contract.Service;
using Hrm.Recruitment.ApplicationCore.Entity;
using Hrm.Recruitment.ApplicationCore.Model.Request;
using Hrm.Recruitment.ApplicationCore.Model.Response;
using Hrm.Recruitment.Infrastructure.Repository;

namespace Hrm.Recruitment.Infrastructure.Service
{
	public class SubmissionStatusServiceAsync : ISubmissionStatusServiceAsync
	{
        private readonly ISubmissionStatusRepositoryAsync submissionStatusRepsoitoryAsync;

        public SubmissionStatusServiceAsync(ISubmissionStatusRepositoryAsync _submissionStatusRepsoitoryAsync)
		{
            submissionStatusRepsoitoryAsync = _submissionStatusRepsoitoryAsync;
        }

        public Task<int> DeleteAsync(int id)
        {
            return submissionStatusRepsoitoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<SubmissionStatusResponseModel>> GetAllAsync()
        {
            var result = await submissionStatusRepsoitoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(model => new SubmissionStatusResponseModel()
                {
                    Id = model.Id,
                    Title = model.Title,
                    IsActive = model.IsActive
                });
            }
            return null;
    }

        public async Task<SubmissionStatusResponseModel> GetByIdAsync(int id)
        {
            var model = await submissionStatusRepsoitoryAsync.GetByIdAsync(id);
            if (model != null)
            {
                return new SubmissionStatusResponseModel()
                {
                    Id = model.Id,
                    Title = model.Title,
                    IsActive = model.IsActive
                };
            }
            return null;
        }

        public Task<int> InsertAsync(SubmissionStatusRequestModel model)
        {
            SubmissionStatus submissionStatus = new SubmissionStatus()
            {
                Title = model.Title,
                IsActive = model.IsActive
            };
            return submissionStatusRepsoitoryAsync.InsertAsync(submissionStatus);
        }

        public async Task<int> UpdateAsync(SubmissionStatusRequestModel model)
        {
            SubmissionStatus submissionStatus = new SubmissionStatus()
            {
                Id = model.Id,
                Title = model.Title,
                IsActive = model.IsActive
            };
            return await submissionStatusRepsoitoryAsync.UpdateAsync(submissionStatus);
        }
    }
}

