using System;
using Hrm.Interview.ApplicationCore.Model.Request;
using Hrm.Interview.ApplicationCore.Model.Response;

namespace Hrm.Interview.ApplicationCore.Contract.Service
{
	public interface IInterviewsServiceAsync : IServiceAsync<InterviewsRequestModel, InterviewsResponseModel>
	{
	}
}

