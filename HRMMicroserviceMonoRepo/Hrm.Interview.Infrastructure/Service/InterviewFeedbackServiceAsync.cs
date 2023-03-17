using System;
using Hrm.Interview.ApplicationCore.Contract.Repository;
using Hrm.Interview.ApplicationCore.Contract.Service;
using Hrm.Interview.ApplicationCore.Entity;
using Hrm.Interview.ApplicationCore.Model.Request;
using Hrm.Interview.ApplicationCore.Model.Response;

namespace Hrm.Interview.Infrastructure.Service
{
	public class InterviewFeedbackServiceAsync : IInterviewFeedbackServiceAsync
	{
        private readonly IInterviewFeedbackRepositoryAsync interviewFeedbackRepositoryAsync;

        public InterviewFeedbackServiceAsync(IInterviewFeedbackRepositoryAsync _interviewFeedbackRepositoryAsync)
		{
            interviewFeedbackRepositoryAsync = _interviewFeedbackRepositoryAsync;
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await interviewFeedbackRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<InterviewFeedbackResponseModel>> GetAllAsync()
        {
            var result = await interviewFeedbackRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(model => new InterviewFeedbackResponseModel()
                {
                    Id = model.Id,
                    Raring = model.Raring,
                    Comment = model.Comment
                });
            }
            return null;
        }

        public async Task<InterviewFeedbackResponseModel> GetByIdAsync(int id)
        {
            var model = await interviewFeedbackRepositoryAsync.GetByIdAsync(id);
            if (model != null)
            {
                return new InterviewFeedbackResponseModel()
                {
                    Id = model.Id,
                    Raring = model.Raring,
                    Comment = model.Comment
                };
            }
            return null;
        }

        public async Task<int> InsertAsync(InterviewFeedbackRequestModel model)
        {
            InterviewFeedback interviewFeedback = new InterviewFeedback()
            {
                Raring = model.Raring,
                Comment = model.Comment
            };
            return await interviewFeedbackRepositoryAsync.InsertAsync(interviewFeedback);
        }

        public async Task<int> UpdateAsync(InterviewFeedbackRequestModel model)
        {
            InterviewFeedback interviewFeedback = new InterviewFeedback()
            {
                Id = model.Id,
                Raring = model.Raring,
                Comment = model.Comment
            };
            return await interviewFeedbackRepositoryAsync.UpdateAsync(interviewFeedback);
        }
    }
}

