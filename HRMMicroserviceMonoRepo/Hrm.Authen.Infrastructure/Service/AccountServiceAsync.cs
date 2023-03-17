using System;
using Hrm.Authen.ApplicationCore.Contract.Repository;
using Hrm.Authen.ApplicationCore.Contract.Service;
using Hrm.Authen.ApplicationCore.Entity;
using Hrm.Authen.ApplicationCore.Model.Request;
using Hrm.Authen.ApplicationCore.Model.Response;
using Hrm.Authen.Infrastructure.Repository;

namespace Hrm.Authen.Infrastructure.Service
{
	public class AccountServiceAsync : IAccountServiceAsync
	{
        private readonly IAccountRepositoryAsync accountRepsoitoryAsync;

        public AccountServiceAsync(IAccountRepositoryAsync _accountRepsoitoryAsync)
		{
            accountRepsoitoryAsync = _accountRepsoitoryAsync;
        }

        public Task<int> DeleteAsync(int id)
        {
            return accountRepsoitoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<AccountResponseModel>> GetAllAsync()
        {
            var result = await accountRepsoitoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(model => new AccountResponseModel()
                {
                    Id = model.Id,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    EmloyeeId = model.EmloyeeId,
                    Email = model.Email,
                    HashPassword = model.HashPassword,
                    Salt = model.Salt
                });
            }
            return null;
    }

        public async Task<AccountResponseModel> GetByIdAsync(int id)
        {
            var model = await accountRepsoitoryAsync.GetByIdAsync(id);
            if (model != null)
            {
                return new AccountResponseModel()
                {
                    Id = model.Id,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    EmloyeeId = model.EmloyeeId,
                    Email = model.Email,
                    HashPassword = model.HashPassword,
                    Salt = model.Salt
                };
            }
            return null;
        }

        public Task<int> InsertAsync(AccountRequestModel model)
        {
            Account account = new Account()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                EmloyeeId = model.EmloyeeId,
                Email = model.Email,
                HashPassword = model.HashPassword,
                Salt = model.Salt
            };
            return accountRepsoitoryAsync.InsertAsync(account);
        }

        public async Task<int> UpdateAsync(AccountRequestModel model)
        {
            Account account = new Account()
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                EmloyeeId = model.EmloyeeId,
                Email = model.Email,
                HashPassword = model.HashPassword,
                Salt = model.Salt
            };
            return await accountRepsoitoryAsync.UpdateAsync(account);
        }
    }
}

