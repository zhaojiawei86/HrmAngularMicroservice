using System;
using Hrm.Onboard.ApplicationCore.Contract.Repository;
using Hrm.Onboard.ApplicationCore.Contract.Service;
using Hrm.Onboard.ApplicationCore.Entity;
using Hrm.Onboard.ApplicationCore.Model.Request;
using Hrm.Onboard.ApplicationCore.Model.Response;
using Hrm.Onboard.Infrastructure.Repository;

namespace Hrm.Onboard.Infrastructure.Service
{
    public class EmployeeStatusServiceAsync : IEmployeeStatusServiceAsync
    {
        private readonly IEmployeeStatusRepositoryAsync employeeStatusRepsoitoryAsync;

        public EmployeeStatusServiceAsync(IEmployeeStatusRepositoryAsync _employeeStatusRepsoitoryAsync)
        {
            employeeStatusRepsoitoryAsync = _employeeStatusRepsoitoryAsync;
        }

        public Task<int> DeleteAsync(int id)
        {
            return employeeStatusRepsoitoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<EmployeeStatusResponseModel>> GetAllAsync()
        {
            var result = await employeeStatusRepsoitoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(model => new EmployeeStatusResponseModel()
                {
                    Id = model.Id,
                    Title = model.Title,
                    ABBR = model.ABBR
                });
            }
            return null;

    }

        public async Task<EmployeeStatusResponseModel> GetByIdAsync(int id)
        {
            var model = await employeeStatusRepsoitoryAsync.GetByIdAsync(id);
            if (model != null)
            {
                return new EmployeeStatusResponseModel()
                {
                    Id = model.Id,
                    Title = model.Title,
                    ABBR = model.ABBR
                };
            }
            return null;
        }

        public Task<int> InsertAsync(EmployeeStatusRequestModel model)
        {
            EmployeeStatus employeeStatus = new EmployeeStatus()
            {
                Title = model.Title,
                ABBR = model.ABBR
            };
            return employeeStatusRepsoitoryAsync.InsertAsync(employeeStatus);
        }

        public async Task<int> UpdateAsync(EmployeeStatusRequestModel model)
        {
            EmployeeStatus employeeStatus = new EmployeeStatus()
            {
                Id = model.Id,
                Title = model.Title,
                ABBR = model.ABBR
            };
            return await employeeStatusRepsoitoryAsync.UpdateAsync(employeeStatus);
        }
    }
}
