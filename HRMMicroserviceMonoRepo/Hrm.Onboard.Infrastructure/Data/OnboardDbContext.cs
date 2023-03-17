using System;
using Hrm.Onboard.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;

namespace Hrm.Onboard.Infrastructure.Data
{
	public class OnboardDbContext : DbContext
	{
        public OnboardDbContext(DbContextOptions<OnboardDbContext> option) : base(option)
        {
        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeCategory> EmployeeCategory { get; set; }
        public DbSet<EmployeeRole> EmployeeRole { get; set; }
        public DbSet<EmployeeStatus> EmployeeStatus { get; set; }
    }
}

