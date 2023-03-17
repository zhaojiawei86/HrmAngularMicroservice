using System;
using Hrm.Authen.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;

namespace Hrm.Authen.Infrastructure.Data;

public class AuthenDbContext : DbContext
{
	public AuthenDbContext(DbContextOptions<AuthenDbContext> option) : base(option)
	{
	}

    public DbSet<Account> Account { get; set; }
    public DbSet<Role> Role { get; set; }
    public DbSet<UserRole> UserRole { get; set; }
}

