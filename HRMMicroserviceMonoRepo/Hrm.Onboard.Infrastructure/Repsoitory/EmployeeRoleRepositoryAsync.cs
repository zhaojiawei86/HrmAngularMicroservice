using System;
using Hrm.Onboard.ApplicationCore.Contract.Repository;
using Hrm.Onboard.ApplicationCore.Entity;
using Hrm.Onboard.Infrastructure.Data;
using Hrm.Onboard.Infrastructure.Repository;

namespace Hrm.Onboard.Infrastructure.Repsoitory
{
    public class EmployeeRoleRepositoryAsync : BaseRepositoryAsync<EmployeeRole>, IEmployeeRoleRepositoryAsync
    {
        public EmployeeRoleRepositoryAsync(OnboardDbContext _context) : base(_context)
        {
        }
    }
}

