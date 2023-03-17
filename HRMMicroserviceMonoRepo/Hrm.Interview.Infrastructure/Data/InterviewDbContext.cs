using System;
using Microsoft.EntityFrameworkCore;
using Hrm.Interview.ApplicationCore.Entity;


namespace Hrm.Interview.Infrastructure.Data
{
    public class InterviewDbContext : DbContext
    {
        public InterviewDbContext(DbContextOptions<InterviewDbContext> options) : base(options)
        {
        }

        public DbSet<Interviews> Interviews { get; set; }
        public DbSet<Interviewer> Interviewer { get; set; }
        public DbSet<InterviewFeedback> InterviewFeedback { get; set; }
        public DbSet<InterviewType> InterviewType { get; set; }
        public DbSet<Recruiter> Recruiter { get; set; }
    }
}

