using System;
using Hrm.Interview.ApplicationCore.Contract.Repository;
using Hrm.Interview.ApplicationCore.Contract.Service;
using Hrm.Interview.ApplicationCore.Entity;
using Hrm.Interview.ApplicationCore.Model.Request;
using Hrm.Interview.ApplicationCore.Model.Response;

namespace Hrm.Interview.Infrastructure.Service
{
	public class InterviewsServiceAsync : IInterviewsServiceAsync
	{
        private readonly IInterviewsRepositoryAsync interviewsRepositoryAsync;

        public InterviewsServiceAsync(IInterviewsRepositoryAsync _interviewsRepositoryAsync)
		{
            interviewsRepositoryAsync = _interviewsRepositoryAsync;
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await interviewsRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<InterviewsResponseModel>> GetAllAsync()
        {
            var result = await interviewsRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(model => new InterviewsResponseModel()
                {
                    Id = model.Id,
                    RecruiterId = model.RecruiterId,
                    SubmissionId = model.SubmissionId,
                    InterviewTypeId = model.InterviewTypeId,
                    InterviewRound = model.InterviewRound,
                    InterviewDate = model.InterviewDate,
                    InterviewerId = model.InterviewerId,
                    InterviewFeedbackId = model.InterviewFeedbackId

                });
            }
            return null;
    }

        public async Task<InterviewsResponseModel> GetByIdAsync(int id)
        {
            var model = await interviewsRepositoryAsync.GetByIdAsync(id);
            if (model != null)
            {
                return new InterviewsResponseModel()
                {
                    Id = model.Id,
                    RecruiterId = model.RecruiterId,
                    SubmissionId = model.SubmissionId,
                    InterviewTypeId = model.InterviewTypeId,
                    InterviewRound = model.InterviewRound,
                    InterviewDate = model.InterviewDate,
                    InterviewerId = model.InterviewerId,
                    InterviewFeedbackId = model.InterviewFeedbackId
                };
            }
            return null;
        }

        public async Task<int> InsertAsync(InterviewsRequestModel model)
        {
            Interviews interviews = new Interviews()
            {
                RecruiterId = model.RecruiterId,
                SubmissionId = model.SubmissionId,
                InterviewTypeId = model.InterviewTypeId,
                InterviewRound = model.InterviewRound,
                InterviewDate = model.InterviewDate,
                InterviewerId = model.InterviewerId,
                InterviewFeedbackId = model.InterviewFeedbackId
            };
            return await interviewsRepositoryAsync.InsertAsync(interviews);
        }

        public async Task<int> UpdateAsync(InterviewsRequestModel model)
        {
            Interviews interviews = new Interviews()
            {
                Id = model.Id,
                RecruiterId = model.RecruiterId,
                SubmissionId = model.SubmissionId,
                InterviewTypeId = model.InterviewTypeId,
                InterviewRound = model.InterviewRound,
                InterviewDate = model.InterviewDate,
                InterviewerId = model.InterviewerId,
                InterviewFeedbackId = model.InterviewFeedbackId
            };
            return await interviewsRepositoryAsync.UpdateAsync(interviews);
        }
    }
}

