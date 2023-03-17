using System;
using Hrm.Recruitment.ApplicationCore.Contract.Repository;
using Hrm.Recruitment.ApplicationCore.Contract.Service;
using Hrm.Recruitment.ApplicationCore.Entity;
using Hrm.Recruitment.ApplicationCore.Model.Request;
using Hrm.Recruitment.Infrastructure.Repository;

namespace Hrm.Recruitment.Infrastructure.Service
{
	public class JobCategoryServiceAsync : IJobCategoryServiceAsync
	{
        private readonly IJobCategoryRepositoryAsync jobCategoryRepositoryAsync;

        public JobCategoryServiceAsync(IJobCategoryRepositoryAsync _jobCategoryRepositoryAsync)
		{
            jobCategoryRepositoryAsync = _jobCategoryRepositoryAsync;
        }

        public Task<int> DeleteAsync(int id)
        {
            return jobCategoryRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<JobCategoryResponseModel>> GetAllAsync()
        {
            var result = await jobCategoryRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(model => new JobCategoryResponseModel()
                {
                    Id = model.Id,
                    Title = model.Title,
                    IsActive = model.IsActive
                });
            }
            return null;
    }

        public async Task<JobCategoryResponseModel> GetByIdAsync(int id)
        {
            var model = await jobCategoryRepositoryAsync.GetByIdAsync(id);
            if (model != null)
            {
                return new JobCategoryResponseModel()
                {
                    Id = model.Id,
                    Title = model.Title,
                    IsActive = model.IsActive
                };
            }
            return null;
        }

        public Task<int> InsertAsync(JobCategoryRequestModel model)
        {
            JobCategory jobCategory = new JobCategory()
            {
                Title = model.Title,
                IsActive = model.IsActive
            };
            return jobCategoryRepositoryAsync.InsertAsync(jobCategory);
        }

        public async Task<int> UpdateAsync(JobCategoryRequestModel model)
        {
            JobCategory jobCategory = new JobCategory()
            {
                Id = model.Id,
                Title = model.Title,
                IsActive = model.IsActive
            };
            return await jobCategoryRepositoryAsync.UpdateAsync(jobCategory);
        }
    }
}

