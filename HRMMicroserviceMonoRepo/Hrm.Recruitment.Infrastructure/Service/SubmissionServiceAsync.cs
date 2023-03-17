using System;
using Hrm.Recruitment.ApplicationCore.Contract.Repository;
using Hrm.Recruitment.ApplicationCore.Contract.Service;
using Hrm.Recruitment.ApplicationCore.Entity;
using Hrm.Recruitment.ApplicationCore.Model.Request;
using Hrm.Recruitment.ApplicationCore.Model.Response;
using Hrm.Recruitment.Infrastructure.Repository;

namespace Hrm.Recruitment.Infrastructure.Service
{
	public class SubmissionServiceAsync : ISubmissionServiceAsync
	{
        private readonly ISubmissionRepositoryAsync submissionRepsoitoryAsync;

        public SubmissionServiceAsync(ISubmissionRepositoryAsync _submissionRepsoitoryAsync)
		{
            submissionRepsoitoryAsync = _submissionRepsoitoryAsync;
        }

        public Task<int> DeleteAsync(int id)
        {
            return submissionRepsoitoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<SubmissionResponseModel>> GetAllAsync()
        {
            var result = await submissionRepsoitoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(model => new SubmissionResponseModel()
                {
                    Id = model.Id,
                    CandidateId = model.CandidateId,
                    JobRequirementId = model.JobRequirementId,
                    AppliedDate = model.AppliedDate,
                    ConfirmedOn = model.ConfirmedOn,
                    RejectedOn = model.RejectedOn,
                    SubmissionStatusId = model.SubmissionStatusId
                });
            }
            return null;
    }

        public async Task<SubmissionResponseModel> GetByIdAsync(int id)
        {
            var model = await submissionRepsoitoryAsync.GetByIdAsync(id);
            if (model != null)
            {
                return new SubmissionResponseModel()
                {
                    Id = model.Id,
                    CandidateId = model.CandidateId,
                    JobRequirementId = model.JobRequirementId,
                    AppliedDate = model.AppliedDate,
                    ConfirmedOn = model.ConfirmedOn,
                    RejectedOn = model.RejectedOn,
                    SubmissionStatusId = model.SubmissionStatusId
                };
            }
            return null;
        }

        public Task<int> InsertAsync(SubmissionRequestModel model)
        {
            Submission submission = new Submission()
            {
                CandidateId = model.CandidateId,
                JobRequirementId = model.JobRequirementId,
                AppliedDate = model.AppliedDate,
                ConfirmedOn = model.ConfirmedOn,
                RejectedOn = model.RejectedOn,
                SubmissionStatusId = model.SubmissionStatusId
            };
            return submissionRepsoitoryAsync.InsertAsync(submission);
        }

        public async Task<int> UpdateAsync(SubmissionRequestModel model)
        {
            Submission submission = new Submission()
            {
                Id = model.Id,
                CandidateId = model.CandidateId,
                JobRequirementId = model.JobRequirementId,
                AppliedDate = model.AppliedDate,
                ConfirmedOn = model.ConfirmedOn,
                RejectedOn = model.RejectedOn,
                SubmissionStatusId = model.SubmissionStatusId
            };
            return await submissionRepsoitoryAsync.UpdateAsync(submission);
        }
    }
}

