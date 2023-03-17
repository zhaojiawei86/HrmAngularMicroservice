using System;
using Hrm.Recruitment.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;

namespace Hrm.Recruitment.Infrastructure.Data;

public class RecruitDbContext : DbContext
{
	public RecruitDbContext(DbContextOptions<RecruitDbContext> option) : base(option)
	{
	}

    public DbSet<JobRequirement> JobRequirement { get; set; }
    public DbSet<JobCategory> JobCategory { get; set; }
    public DbSet<Candidate> Candidate { get; set; }
    public DbSet<Submission> Submission { get; set; }
    public DbSet<SubmissionStatus> SubmissionStatus { get; set; }
}

