using System;
using Dapper;
using Hrm.Interview.ApplicationCore.Contract.Repository;
using Hrm.Interview.ApplicationCore.Entity;
using Hrm.Interview.Infrastructure.Data;
using Microsoft.Extensions.Configuration;

namespace Hrm.Interview.Infrastructure.Repository
{
	public class InterviewFeedbackRepositoryAsync : IInterviewFeedbackRepositoryAsync
	{
        private readonly IConfiguration configuration;
        DapperDbContext dbContext;
		public InterviewFeedbackRepositoryAsync(IConfiguration _configuration)
		{
            configuration = _configuration;
            dbContext = new DapperDbContext(configuration);
        }

        public async Task<int> DeleteAsync(int id)
        {
            using (var conn = dbContext.GetConnection())
            {
                var query = "DELETE FROM [InterviewFeedback] WHERE Id = @pid";
                return await conn.ExecuteAsync(query, new { pid = id });
            }

        }

        public async Task<IEnumerable<InterviewFeedback>> GetAllAsync()
        {
            using(var conn = dbContext.GetConnection())
            {
                var query = "SELECT * FROM InterviewFeedback";
                return await conn.QueryAsync<InterviewFeedback>(query);
            }
        }

        public async Task<InterviewFeedback> GetByIdAsync(int id)
        {
            using (var conn = dbContext.GetConnection())
            {
                var query = "SELECT * FROM InterviewFeedback WHERE Id = @pid";
                return await conn.QuerySingleOrDefaultAsync<InterviewFeedback>(query, new { pid = id });
            }
        }

        public async Task<int> InsertAsync(InterviewFeedback entity)
        {
            using (var conn = dbContext.GetConnection())
            {
                var query = "INSERT INTO InterviewFeedback VALUES (@Raring, @Comment)";
                return await conn.ExecuteAsync(query, entity);
            }
        }

        public async Task<int> UpdateAsync(InterviewFeedback entity)
        {
            using (var conn = dbContext.GetConnection())
            {
                var query = "UPDATE InterviewFeedback SET Raring=@Raring, Comment=@Comment WHERE Id = @Id";
                return await conn.ExecuteAsync(query, entity);
            }
        }
    }
}

