using System;
using Hrm.Authen.ApplicationCore.Contract.Repository;
using Hrm.Authen.ApplicationCore.Contract.Service;
using Hrm.Authen.ApplicationCore.Entity;
using Hrm.Authen.ApplicationCore.Model.Request;
using Hrm.Authen.ApplicationCore.Model.Response;
using Hrm.Authen.Infrastructure.Repository;

namespace Hrm.Authen.Infrastructure.Service
{
	public class UserRoleServiceAsync : IUserRoleServiceAsync
	{
        private readonly IUserRoleRepositoryAsync userRoleRepsoitoryAsync;

        public UserRoleServiceAsync(IUserRoleRepositoryAsync _userRoleRepsoitoryAsync)
		{
            userRoleRepsoitoryAsync = _userRoleRepsoitoryAsync;
        }

        public Task<int> DeleteAsync(int id)
        {
            return userRoleRepsoitoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<UserRoleResponseModel>> GetAllAsync()
        {
            var result = await userRoleRepsoitoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(model => new UserRoleResponseModel()
                {
                    Id = model.Id,
                    RoleId = model.RoleId,
                    AccountId = model.AccountId
                });
            }
            return null;
    }

        public async Task<UserRoleResponseModel> GetByIdAsync(int id)
        {
            var model = await userRoleRepsoitoryAsync.GetByIdAsync(id);
            if (model != null)
            {
                return new UserRoleResponseModel()
                {
                    Id = model.Id,
                    RoleId = model.RoleId,
                    AccountId = model.AccountId
                };
            }
            return null;
        }

        public Task<int> InsertAsync(UserRoleRequestModel model)
        {
            UserRole userRole = new UserRole()
            {
                RoleId = model.RoleId,
                AccountId = model.AccountId
            };
            return userRoleRepsoitoryAsync.InsertAsync(userRole);
        }

        public async Task<int> UpdateAsync(UserRoleRequestModel model)
        {
            UserRole userRole = new UserRole()
            {
                Id = model.Id,
                RoleId = model.RoleId,
                AccountId = model.AccountId
            };
            return await userRoleRepsoitoryAsync.UpdateAsync(userRole);
        }
    }
}

