using System;
using Dapper;
using Hrm.Interview.ApplicationCore.Contract.Repository;
using Hrm.Interview.ApplicationCore.Entity;
using Hrm.Interview.Infrastructure.Data;
using Microsoft.Extensions.Configuration;

namespace Hrm.Interview.Infrastructure.Repository
{
	public class InterviewerRepositoryAsync : IInterviewerRepositoryAsync
	{
        private readonly IConfiguration configuration;
        DapperDbContext dbContext;
		public InterviewerRepositoryAsync(IConfiguration _configuration)
		{
            configuration = _configuration;
            dbContext = new DapperDbContext(configuration);
        }

        public async Task<int> DeleteAsync(int id)
        {
            using (var conn = dbContext.GetConnection())
            {
                var query = "DELETE FROM [Interviewer] WHERE Id = @pid";
                return await conn.ExecuteAsync(query, new { pid = id });
            }

        }

        public async Task<IEnumerable<Interviewer>> GetAllAsync()
        {
            using(var conn = dbContext.GetConnection())
            {
                var query = "SELECT * FROM Interviewer";
                return await conn.QueryAsync<Interviewer>(query);
            }
        }

        public async Task<Interviewer> GetByIdAsync(int id)
        {
            using (var conn = dbContext.GetConnection())
            {
                var query = "SELECT * FROM Interviewer WHERE Id = @pid";
                return await conn.QuerySingleOrDefaultAsync<Interviewer>(query, new { pid = id });
            }
        }

        public async Task<int> InsertAsync(Interviewer entity)
        {
            using (var conn = dbContext.GetConnection())
            {
                var query = "INSERT INTO Interviewer VALUES (@FirstName, @LastName, @EmployeeId)";
                return await conn.ExecuteAsync(query, entity);
            }
        }

        public async Task<int> UpdateAsync(Interviewer entity)
        {
            using (var conn = dbContext.GetConnection())
            {
                var query = "UPDATE Interviewer SET FirstName=@FirstName, LastName=@LastName, EmployeeId=@EmployeeId WHERE Id = @Id";
                return await conn.ExecuteAsync(query, entity);
            }
        }
    }
}

