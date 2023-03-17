using System;
using Hrm.Authen.ApplicationCore.Contract.Repository;
using Hrm.Authen.ApplicationCore.Entity;
using Hrm.Authen.Infrastructure.Data;

namespace Hrm.Authen.Infrastructure.Repository
{
	public class RoleRepositoryAsync : BaseRepositoryAsync<Role>, IRoleRepositoryAsync
	{
		public RoleRepositoryAsync(AuthenDbContext _context): base(_context)
		{

		}
		
	}
}

