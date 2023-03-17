using System;
using Hrm.Onboard.ApplicationCore.Contract.Repository;
using Hrm.Onboard.ApplicationCore.Contract.Service;
using Hrm.Onboard.ApplicationCore.Entity;
using Hrm.Onboard.ApplicationCore.Model.Request;
using Hrm.Onboard.ApplicationCore.Model.Response;
using Hrm.Onboard.Infrastructure.Repository;

namespace Hrm.Onboard.Infrastructure.Service
{
    public class EmployeeCategoryServiceAsync : IEmployeeCategoryServiceAsync
    {
        private readonly IEmployeeCategoryRepositoryAsync employeeCategoryRepsoitoryAsync;

        public EmployeeCategoryServiceAsync(IEmployeeCategoryRepositoryAsync _employeeCategoryRepsoitoryAsync)
        {
            employeeCategoryRepsoitoryAsync = _employeeCategoryRepsoitoryAsync;
        }

        public Task<int> DeleteAsync(int id)
        {
            return employeeCategoryRepsoitoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<EmployeeCategoryResponseModel>> GetAllAsync()
        {
            var result = await employeeCategoryRepsoitoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(model => new EmployeeCategoryResponseModel()
                {
                    Id = model.Id,
                    Title = model.Title,
                    description = model.description,
                    IsActive = model.IsActive
                });
            }
            return null;
    }

        public async Task<EmployeeCategoryResponseModel> GetByIdAsync(int id)
        {
            var model = await employeeCategoryRepsoitoryAsync.GetByIdAsync(id);
            if (model != null)
            {
                return new EmployeeCategoryResponseModel()
                {
                    Id = model.Id,
                    Title = model.Title,
                    description = model.description,
                    IsActive = model.IsActive
                };
            }
            return null;
        }

        public Task<int> InsertAsync(EmployeeCategoryRequestModel model)
        {
            EmployeeCategory employeeCategory = new EmployeeCategory()
            {
                Title = model.Title,
                description = model.description,
                IsActive = model.IsActive
            };
            return employeeCategoryRepsoitoryAsync.InsertAsync(employeeCategory);
        }

        public async Task<int> UpdateAsync(EmployeeCategoryRequestModel model)
        {
            EmployeeCategory employeeCategory = new EmployeeCategory()
            {
                Id = model.Id,
                Title = model.Title,
                description = model.description,
                IsActive = model.IsActive
            };
            return await employeeCategoryRepsoitoryAsync.UpdateAsync(employeeCategory);
        }
    }
}
