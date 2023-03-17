using System;
using Hrm.Recruitment.ApplicationCore.Contract.Repository;
using Hrm.Recruitment.ApplicationCore.Contract.Service;
using Hrm.Recruitment.ApplicationCore.Entity;
using Hrm.Recruitment.ApplicationCore.Model.Request;
using Hrm.Recruitment.Infrastructure.Repository;

namespace Hrm.Recruitment.Infrastructure.Service
{
	public class JobRequirementServiceAsync : IJobRequirementServiceAsync
	{
        private readonly IJobRequirementRepositoryAsync jobRequirementRepositoryAsync;

        public JobRequirementServiceAsync(IJobRequirementRepositoryAsync _jobRequirementRepositoryAsync)
		{
            jobRequirementRepositoryAsync = _jobRequirementRepositoryAsync;
        }

        public Task<int> DeleteAsync(int id)
        {
            return jobRequirementRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<JobRequirementResponseModel>> GetAllAsync()
        {
            var result = await jobRequirementRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(model => new JobRequirementResponseModel()
                {
                    Id = model.Id,
                    Title = model.Title,
                    Description = model.Description,
                    NoOfPosition = model.NoOfPosition,
                    HiringManagerId = model.HiringManagerId,
                    HiringManagerName = model.HiringManagerName,
                    CreatedOn = model.CreatedOn,
                    ClosedOn = model.ClosedOn,
                    StartDate = model.StartDate,
                    IsActive = model.IsActive,
                    JobCategoryId = model.JobCategoryId
                });
            }
            return null;
    }

        public async Task<JobRequirementResponseModel> GetByIdAsync(int id)
        {
            var model = await jobRequirementRepositoryAsync.GetByIdAsync(id);
            if (model != null)
            {
                return new JobRequirementResponseModel()
                {
                    Id = model.Id,
                    Title = model.Title,
                    Description = model.Description,
                    NoOfPosition = model.NoOfPosition,
                    HiringManagerId = model.HiringManagerId,
                    HiringManagerName = model.HiringManagerName,
                    CreatedOn = model.CreatedOn,
                    ClosedOn = model.ClosedOn,
                    StartDate = model.StartDate,
                    IsActive = model.IsActive,
                    JobCategoryId = model.JobCategoryId
                };
            }
            return null;
        }

        public Task<int> InsertAsync(JobRequirementRequestModel model)
        {
            JobRequirement jobRequirement = new JobRequirement()
            {
                Title = model.Title,
                Description = model.Description,
                NoOfPosition = model.NoOfPosition,
                HiringManagerId = model.HiringManagerId,
                HiringManagerName = model.HiringManagerName,
                CreatedOn = model.CreatedOn,
                ClosedOn = model.ClosedOn,
                StartDate = model.StartDate,
                IsActive = model.IsActive,
                JobCategoryId = model.JobCategoryId
            };
            return jobRequirementRepositoryAsync.InsertAsync(jobRequirement);
        }

        public async Task<int> UpdateAsync(JobRequirementRequestModel model)
        {
            JobRequirement jobRequirement = new JobRequirement()
            {
                Id = model.Id,
                Title = model.Title,
                Description = model.Description,
                NoOfPosition = model.NoOfPosition,
                HiringManagerId = model.HiringManagerId,
                HiringManagerName = model.HiringManagerName,
                CreatedOn = model.CreatedOn,
                ClosedOn = model.ClosedOn,
                StartDate = model.StartDate,
                IsActive = model.IsActive,
                JobCategoryId = model.JobCategoryId
            };
            return await jobRequirementRepositoryAsync.UpdateAsync(jobRequirement);
        }
    }
}

