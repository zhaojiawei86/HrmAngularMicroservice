using System;
using Dapper;
using Hrm.Interview.ApplicationCore.Contract.Repository;
using Hrm.Interview.ApplicationCore.Entity;
using Hrm.Interview.Infrastructure.Data;
using Microsoft.Extensions.Configuration;

namespace Hrm.Interview.Infrastructure.Repository
{
	public class InterviewTypeRepositoryAsync : IInterviewTypeRepositoryAsync
	{
        DapperDbContext dbContext;
        private readonly IConfiguration configuration;

        public InterviewTypeRepositoryAsync(IConfiguration _configuration)
		{
            configuration = _configuration;
            dbContext = new DapperDbContext(configuration);
        }

 

        public async Task<IEnumerable<InterviewType>> GetAllAsync()
        {
            using(var conn = dbContext.GetConnection())
            {
                var query = "SELECT * FROM InterviewType";
                return await conn.QueryAsync<InterviewType>(query);
            }
        }

        public async Task<InterviewType> GetByIdAsync(int id)
        {
            using (var conn = dbContext.GetConnection())
            {
                var query = "SELECT * FROM InterviewType WHERE Id = @pid";
                return await conn.QuerySingleOrDefaultAsync<InterviewType>(query, new { pid = id });
            }
        }

        public async Task<int> InsertAsync(InterviewType entity)
        {
            using (var conn = dbContext.GetConnection())
            {
                var query = "INSERT INTO InterviewType VALUES (@Title, @IsActive)";
                return await conn.ExecuteAsync(query, entity);
            }
        }

        public async Task<int> UpdateAsync(InterviewType entity)
        {
            using (var conn = dbContext.GetConnection())
            {
                var query = "UPDATE InterviewType SET Title=@Title, IsActive=@IsActive WHERE Id = @Id";
                return await conn.ExecuteAsync(query, entity);
            }
        }

        public async Task<int> DeleteAsync(int id)
        {
            using (var conn = dbContext.GetConnection())
            {
                var query = "DELETE FROM [InterviewType] WHERE Id = @pid";
                return await conn.ExecuteAsync(query, new { pid = id });
            }

        }
    }
}

