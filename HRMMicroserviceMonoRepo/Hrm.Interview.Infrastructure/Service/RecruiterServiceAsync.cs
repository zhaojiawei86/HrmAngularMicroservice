using System;
using Hrm.Interview.ApplicationCore.Contract.Repository;
using Hrm.Interview.ApplicationCore.Contract.Service;
using Hrm.Interview.ApplicationCore.Entity;
using Hrm.Interview.ApplicationCore.Model.Request;
using Hrm.Interview.ApplicationCore.Model.Response;

namespace Hrm.Interview.Infrastructure.Service
{
	public class RecruiterServiceAsync : IRecruiterServiceAsync
	{
        private readonly IRecruiterRepositoryAsync recruiterRepositoryAsync;

        public RecruiterServiceAsync(IRecruiterRepositoryAsync _recruiterRepositoryAsync)
		{
            recruiterRepositoryAsync = _recruiterRepositoryAsync;
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await recruiterRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<RecruiterResponseModel>> GetAllAsync()
        {
            var result = await recruiterRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(model => new RecruiterResponseModel()
                {
                    Id = model.Id,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    EmployeeId = model.EmployeeId
                });
            }
            return null;
        }

        public async Task<RecruiterResponseModel> GetByIdAsync(int id)
        {
            var model = await recruiterRepositoryAsync.GetByIdAsync(id);
            if (model != null)
            {
                return new RecruiterResponseModel()
                {
                    Id = model.Id,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    EmployeeId = model.EmployeeId
                };
            }
            return null;
        }

        public async Task<int> InsertAsync(RecruiterRequestModel model)
        {
            Recruiter recruiter = new Recruiter()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                EmployeeId = model.EmployeeId
            };
            return await recruiterRepositoryAsync.InsertAsync(recruiter);
        }

        public async Task<int> UpdateAsync(RecruiterRequestModel model)
        {
            Recruiter recruiter = new Recruiter()
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                EmployeeId = model.EmployeeId
            };
            return await recruiterRepositoryAsync.UpdateAsync(recruiter);
        }
    }
}

