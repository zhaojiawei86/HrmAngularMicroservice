using System;
using Hrm.Onboard.ApplicationCore.Model.Request;
using Hrm.Onboard.ApplicationCore.Model.Response;

namespace Hrm.Onboard.ApplicationCore.Contract.Service
{
    public interface IEmployeeStatusServiceAsync : IServiceAsync<EmployeeStatusRequestModel, EmployeeStatusResponseModel>
    {
    }
}

