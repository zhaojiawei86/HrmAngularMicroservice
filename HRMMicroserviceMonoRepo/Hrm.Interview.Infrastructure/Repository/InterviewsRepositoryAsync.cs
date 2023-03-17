using System;
using Dapper;
using Hrm.Interview.ApplicationCore.Contract.Repository;
using Hrm.Interview.ApplicationCore.Entity;
using Hrm.Interview.Infrastructure.Data;
using Microsoft.Extensions.Configuration;

namespace Hrm.Interview.Infrastructure.Repository
{
	public class InterviewsRepositoryAsync : IInterviewsRepositoryAsync
	{
        private readonly IConfiguration configuration;
        DapperDbContext dbContext;
		public InterviewsRepositoryAsync(IConfiguration _configuration)
		{
            configuration = _configuration;
            dbContext = new DapperDbContext(configuration);
        }

        public async Task<int> DeleteAsync(int id)
        {
            using (var conn = dbContext.GetConnection())
            {
                var query = "DELETE FROM [Interviews] WHERE Id = @pid";
                return await conn.ExecuteAsync(query, new { pid = id });
            }

        }

        public async Task<IEnumerable<Interviews>> GetAllAsync()
        {
            using(var conn = dbContext.GetConnection())
            {
                var query = "SELECT * FROM Interviews";
                return await conn.QueryAsync<Interviews>(query);
            }
        }

        public async Task<Interviews> GetByIdAsync(int id)
        {
            using (var conn = dbContext.GetConnection())
            {
                var query = "SELECT * FROM Interviews WHERE Id = @pid";
                return await conn.QuerySingleOrDefaultAsync<Interviews>(query, new { pid = id });
            }
        }

        public async Task<int> InsertAsync(Interviews entity)
        {
            using (var conn = dbContext.GetConnection())
            {
                var query = "INSERT INTO Interviews VALUES (@RecruiterId, @SubmissionId, @InterviewTypeId, @InterviewRound, @InterviewDate, @InterviewerId, @InterviewFeedbackId)";
                return await conn.ExecuteAsync(query, entity);
            }
        }

        public async Task<int> UpdateAsync(Interviews entity)
        {
            using (var conn = dbContext.GetConnection())
            {
                var query = "UPDATE Interviews SET RecruiterId=@RecruiterId, SubmissionId=@SubmissionId, InterviewTypeId=@InterviewTypeId, InterviewRound=@InterviewRound, InterviewDate=@InterviewDate, InterviewerId=@InterviewerId, InterviewFeedbackId=@InterviewFeedbackId WHERE Id = @Id";
                return await conn.ExecuteAsync(query, entity);
            }
        }
    }
}

