using System;
using Hrm.Authen.ApplicationCore.Contract.Repository;
using Hrm.Authen.ApplicationCore.Entity;
using Hrm.Authen.Infrastructure.Data;

namespace Hrm.Authen.Infrastructure.Repository
{
	public class AccountRepositoryAsync : BaseRepositoryAsync<Account>, IAccountRepositoryAsync
	{
		public AccountRepositoryAsync(AuthenDbContext _context): base(_context)
		{

		}
		
	}
}

