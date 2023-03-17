using System;
using Hrm.Authen.ApplicationCore.Contract.Repository;
using Hrm.Authen.ApplicationCore.Contract.Service;
using Hrm.Authen.ApplicationCore.Entity;
using Hrm.Authen.ApplicationCore.Model.Request;
using Hrm.Authen.ApplicationCore.Model.Response;
using Hrm.Authen.Infrastructure.Repository;

namespace Hrm.Authen.Infrastructure.Service
{
	public class RoleServiceAsync : IRoleServiceAsync
	{
        private readonly IRoleRepositoryAsync roleRepsoitoryAsync;

        public RoleServiceAsync(IRoleRepositoryAsync _roleRepsoitoryAsync)
		{
            roleRepsoitoryAsync = _roleRepsoitoryAsync;
        }

        public Task<int> DeleteAsync(int id)
        {
            return roleRepsoitoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<RoleResponseModel>> GetAllAsync()
        {
            var result = await roleRepsoitoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(model => new RoleResponseModel()
                {
                    Id = model.Id,
                    Name = model.Name,
                    Description = model.Description
                });
            }
            return null;
    }

        public async Task<RoleResponseModel> GetByIdAsync(int id)
        {
            var model = await roleRepsoitoryAsync.GetByIdAsync(id);
            if (model != null)
            {
                return new RoleResponseModel()
                {
                    Id = model.Id,
                    Name = model.Name,
                    Description = model.Description
                };
            }
            return null;
        }

        public Task<int> InsertAsync(RoleRequestModel model)
        {
            Role role = new Role()
            {
                Name = model.Name,
                Description = model.Description
            };
            return roleRepsoitoryAsync.InsertAsync(role);
        }

        public async Task<int> UpdateAsync(RoleRequestModel model)
        {
            Role role = new Role()
            {
                Id = model.Id,
                Name = model.Name,
                Description = model.Description
            };
            return await roleRepsoitoryAsync.UpdateAsync(role);
        }
    }
}

