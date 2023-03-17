using System;
using Hrm.Authen.ApplicationCore.Model.Request;
using Hrm.Authen.ApplicationCore.Model.Response;

namespace Hrm.Authen.ApplicationCore.Contract.Service
{
	public interface IUserRoleServiceAsync : IServiceAsync<UserRoleRequestModel, UserRoleResponseModel>
	{
	}
}

