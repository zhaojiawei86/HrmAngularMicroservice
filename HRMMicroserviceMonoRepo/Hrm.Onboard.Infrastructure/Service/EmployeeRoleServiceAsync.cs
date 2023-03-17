using System;
using Hrm.Onboard.ApplicationCore.Contract.Repository;
using Hrm.Onboard.ApplicationCore.Contract.Service;
using Hrm.Onboard.ApplicationCore.Entity;
using Hrm.Onboard.ApplicationCore.Model.Request;
using Hrm.Onboard.ApplicationCore.Model.Response;
using Hrm.Onboard.Infrastructure.Repository;

namespace Hrm.Onboard.Infrastructure.Service
{
    public class EmployeeRoleServiceAsync : IEmployeeRoleServiceAsync
    {
        private readonly IEmployeeRoleRepositoryAsync employeeRoleRepsoitoryAsync;

        public EmployeeRoleServiceAsync(IEmployeeRoleRepositoryAsync _employeeRoleRepsoitoryAsync)
        {
            employeeRoleRepsoitoryAsync = _employeeRoleRepsoitoryAsync;
        }

        public Task<int> DeleteAsync(int id)
        {
            return employeeRoleRepsoitoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<EmployeeRoleResponseModel>> GetAllAsync()
        {
            var result = await employeeRoleRepsoitoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(model => new EmployeeRoleResponseModel()
                {
                    Id = model.Id,
                    Title = model.Title,
                    ABBR = model.ABBR
                });
            }
            return null;

    }

        public async Task<EmployeeRoleResponseModel> GetByIdAsync(int id)
        {
            var model = await employeeRoleRepsoitoryAsync.GetByIdAsync(id);
            if (model != null)
            {
                return new EmployeeRoleResponseModel()
                {
                    Id = model.Id,
                    Title = model.Title,
                    ABBR = model.ABBR
                };
            }
            return null;
        }

        public Task<int> InsertAsync(EmployeeRoleRequestModel model)
        {
            EmployeeRole employeeRole = new EmployeeRole()
            {
                Title = model.Title,
                ABBR = model.ABBR
            };
            return employeeRoleRepsoitoryAsync.InsertAsync(employeeRole);
        }

        public async Task<int> UpdateAsync(EmployeeRoleRequestModel model)
        {
            EmployeeRole employeeRole = new EmployeeRole()
            {
                Id = model.Id,
                Title = model.Title,
                ABBR = model.ABBR
            };
            return await employeeRoleRepsoitoryAsync.UpdateAsync(employeeRole);
        }
    }
}
