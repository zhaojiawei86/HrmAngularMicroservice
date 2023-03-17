using System;
using Hrm.Recruitment.ApplicationCore.Model.Request;
using Hrm.Recruitment.ApplicationCore.Model.Response;

namespace Hrm.Recruitment.ApplicationCore.Contract.Service
{
	public interface IJobRequirementServiceAsync : IServiceAsync<JobRequirementRequestModel, JobRequirementResponseModel>
	{
	}
}

