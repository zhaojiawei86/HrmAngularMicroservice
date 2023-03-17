using System;
using Dapper;
using Hrm.Interview.ApplicationCore.Contract.Repository;
using Hrm.Interview.ApplicationCore.Entity;
using Hrm.Interview.Infrastructure.Data;
using Microsoft.Extensions.Configuration;

namespace Hrm.Interview.Infrastructure.Repository
{
	public class RecruiterRepositoryAsync : IRecruiterRepositoryAsync
	{
        DapperDbContext dbContext;
        private readonly IConfiguration configuration;

        public RecruiterRepositoryAsync(IConfiguration _configuration)
		{
            configuration = _configuration;
            dbContext = new DapperDbContext(configuration);
        }

 

        public async Task<IEnumerable<Recruiter>> GetAllAsync()
        {
            using(var conn = dbContext.GetConnection())
            {
                var query = "SELECT * FROM Recruiter";
                return await conn.QueryAsync<Recruiter>(query);
            }
        }

        public async Task<Recruiter> GetByIdAsync(int id)
        {
            using (var conn = dbContext.GetConnection())
            {
                var query = "SELECT * FROM Recruiter WHERE Id = @pid";
                return await conn.QuerySingleOrDefaultAsync<Recruiter>(query, new { pid = id });
            }
        }

        public async Task<int> InsertAsync(Recruiter entity)
        {
            using (var conn = dbContext.GetConnection())
            {
                var query = "INSERT INTO Recruiter VALUES (@FirstName, @LastName, @EmployeeId)";
                return await conn.ExecuteAsync(query, entity);
            }
        }

        public async Task<int> UpdateAsync(Recruiter entity)
        {
            using (var conn = dbContext.GetConnection())
            {
                var query = "UPDATE Recruiter SET FirstName=@FirstName, LastName=@LastName, EmployeeId=@EmployeeId WHERE Id = @Id";
                return await conn.ExecuteAsync(query, entity);
            }
        }

        public async Task<int> DeleteAsync(int id)
        {
            using (var conn = dbContext.GetConnection())
            {
                var query = "DELETE FROM [Recruiter] WHERE Id = @pid";
                return await conn.ExecuteAsync(query, new { pid = id });
            }

        }
    }
}

