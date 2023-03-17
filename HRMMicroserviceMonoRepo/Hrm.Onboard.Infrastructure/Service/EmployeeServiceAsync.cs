using System;
using Hrm.Onboard.ApplicationCore.Contract.Repository;
using Hrm.Onboard.ApplicationCore.Contract.Service;
using Hrm.Onboard.ApplicationCore.Entity;
using Hrm.Onboard.ApplicationCore.Model.Request;
using Hrm.Onboard.ApplicationCore.Model.Response;
using Hrm.Onboard.Infrastructure.Repository;

namespace Hrm.Onboard.Infrastructure.Service
{
    public class EmployeeServiceAsync : IEmployeeServiceAsync
    {
        private readonly IEmployeeRepositoryAsync employeeRepsoitoryAsync;

        public EmployeeServiceAsync(IEmployeeRepositoryAsync _employeeRepsoitoryAsync)
        {
            employeeRepsoitoryAsync = _employeeRepsoitoryAsync;
        }

        public Task<int> DeleteAsync(int id)
        {
            return employeeRepsoitoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<EmployeeResponseModel>> GetAllAsync()
        {
            var result = await employeeRepsoitoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(model => new EmployeeResponseModel()
                {
                    Id = model.Id,
                    FirstName = model.FirstName,
                    MiddleName = model.MiddleName,
                    LastName = model.LastName,
                    SSN = model.SSN,
                    Email = model.Email,
                    Address = model.Address,
                    HireDate = model.HireDate,
                    EndDate = model.EndDate,
                    EmployeeCategoryId = model.EmployeeCategoryId,
                    EmployeeStatusId = model.EmployeeStatusId,
                    EmployeeRoleId = model.EmployeeRoleId,
                    DOB = model.DOB,
                    Phone = model.Phone
                });
            }
            return null;

    }

        public async Task<EmployeeResponseModel> GetByIdAsync(int id)
        {
            var model = await employeeRepsoitoryAsync.GetByIdAsync(id);
            if (model != null)
            {
                return new EmployeeResponseModel()
                {
                    Id = model.Id,
                    FirstName = model.FirstName,
                    MiddleName = model.MiddleName,
                    LastName = model.LastName,
                    SSN = model.SSN,
                    Email = model.Email,
                    Address = model.Address,
                    HireDate = model.HireDate,
                    EndDate = model.EndDate,
                    EmployeeCategoryId = model.EmployeeCategoryId,
                    EmployeeStatusId = model.EmployeeStatusId,
                    EmployeeRoleId = model.EmployeeRoleId,
                    DOB = model.DOB,
                    Phone = model.Phone
                };
            }
            return null;
        }

        public Task<int> InsertAsync(EmployeeRequestModel model)
        {
            Employee employee = new Employee()
            {
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                SSN = model.SSN,
                Email = model.Email,
                Address = model.Address,
                HireDate = model.HireDate,
                EndDate = model.EndDate,
                EmployeeCategoryId = model.EmployeeCategoryId,
                EmployeeStatusId = model.EmployeeStatusId,
                EmployeeRoleId = model.EmployeeRoleId,
                DOB = model.DOB,
                Phone = model.Phone
            };
            return employeeRepsoitoryAsync.InsertAsync(employee);
        }

        public async Task<int> UpdateAsync(EmployeeRequestModel model)
        {
            Employee employee = new Employee()
            {
                Id = model.Id,
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                SSN = model.SSN,
                Email = model.Email,
                Address = model.Address,
                HireDate = model.HireDate,
                EndDate = model.EndDate,
                EmployeeCategoryId = model.EmployeeCategoryId,
                EmployeeStatusId = model.EmployeeStatusId,
                EmployeeRoleId = model.EmployeeRoleId,
                DOB = model.DOB,
                Phone = model.Phone
            };
            return await employeeRepsoitoryAsync.UpdateAsync(employee);
        }
    }
}
