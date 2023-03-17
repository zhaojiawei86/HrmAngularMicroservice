using System;
using Hrm.Onboard.ApplicationCore.Contract.Repository;
using Hrm.Onboard.ApplicationCore.Entity;
using Hrm.Onboard.Infrastructure.Data;
using Hrm.Onboard.Infrastructure.Repository;

namespace Hrm.Onboard.Infrastructure.Repsoitory
{
    public class EmployeeStatusRepositoryAsync : BaseRepositoryAsync<EmployeeStatus>, IEmployeeStatusRepositoryAsync
    {
        public EmployeeStatusRepositoryAsync(OnboardDbContext _context) : base(_context)
        {
        }
    }
}

