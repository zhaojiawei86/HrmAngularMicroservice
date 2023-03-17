using System;
using Hrm.Interview.ApplicationCore.Contract.Repository;
using Hrm.Interview.ApplicationCore.Contract.Service;
using Hrm.Interview.ApplicationCore.Entity;
using Hrm.Interview.ApplicationCore.Model.Request;
using Hrm.Interview.ApplicationCore.Model.Response;

namespace Hrm.Interview.Infrastructure.Service
{
	public class InterviewTypeServiceAsync : IInterviewTypeServiceAsync
	{
        private readonly IInterviewTypeRepositoryAsync interviewTypeRepositoryAsync;

        public InterviewTypeServiceAsync(IInterviewTypeRepositoryAsync _interviewTypeRepositoryAsync)
		{
            interviewTypeRepositoryAsync = _interviewTypeRepositoryAsync;
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await interviewTypeRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<InterviewTypeResponseModel>> GetAllAsync()
        {
            var result = await interviewTypeRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(model => new InterviewTypeResponseModel()
                {
                    Id = model.Id,
                    Title = model.Title,
                    IsActive = model.IsActive
                });
            }
            return null;
        }

        public async Task<InterviewTypeResponseModel> GetByIdAsync(int id)
        {
            var model = await interviewTypeRepositoryAsync.GetByIdAsync(id);
            if (model != null)
            {
                return new InterviewTypeResponseModel()
                {
                    Id = model.Id,
                    Title = model.Title,
                    IsActive = model.IsActive
                };
            }
            return null;
        }

        public async Task<int> InsertAsync(InterviewTypeRequestModel model)
        {
            InterviewType interviewType = new InterviewType()
            {
                Title = model.Title,
                IsActive = model.IsActive
            };
            return await interviewTypeRepositoryAsync.InsertAsync(interviewType);
        }

        public async Task<int> UpdateAsync(InterviewTypeRequestModel model)
        {
            InterviewType interviewType = new InterviewType()
            {
                Id = model.Id,
                Title = model.Title,
                IsActive = model.IsActive
            };
            return await interviewTypeRepositoryAsync.UpdateAsync(interviewType);
        }
    }
}

