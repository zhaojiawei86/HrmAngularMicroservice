using System;
using Hrm.Interview.ApplicationCore.Contract.Repository;
using Hrm.Interview.ApplicationCore.Contract.Service;
using Hrm.Interview.ApplicationCore.Entity;
using Hrm.Interview.ApplicationCore.Model.Request;
using Hrm.Interview.ApplicationCore.Model.Response;

namespace Hrm.Interview.Infrastructure.Service
{
	public class InterviewerServiceAsync : IInterviewerServiceAsync
	{
        private readonly IInterviewerRepositoryAsync interviewerRepositoryAsync;

        public InterviewerServiceAsync(IInterviewerRepositoryAsync _interviewerRepositoryAsync)
		{
            interviewerRepositoryAsync = _interviewerRepositoryAsync;
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await interviewerRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<InterviewerResponseModel>> GetAllAsync()
        {
            var result = await interviewerRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(model => new InterviewerResponseModel()
                {
                    Id = model.Id,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    EmployeeId = model.EmployeeId
                });
            }
            return null;
    }

        public async Task<InterviewerResponseModel> GetByIdAsync(int id)
        {
            var model = await interviewerRepositoryAsync.GetByIdAsync(id);
            if (model != null)
            {
                return new InterviewerResponseModel()
                {
                    Id = model.Id,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    EmployeeId = model.EmployeeId
                };
            }
            return null;
        }

        public async Task<int> InsertAsync(InterviewerRequestModel model)
        {
            Interviewer interviewer = new Interviewer()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                EmployeeId = model.EmployeeId
            };
            return await interviewerRepositoryAsync.InsertAsync(interviewer);
        }

        public async Task<int> UpdateAsync(InterviewerRequestModel model)
        {
            Interviewer interviewer = new Interviewer()
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                EmployeeId = model.EmployeeId
            };
            return await interviewerRepositoryAsync.UpdateAsync(interviewer);
        }
    }
}

