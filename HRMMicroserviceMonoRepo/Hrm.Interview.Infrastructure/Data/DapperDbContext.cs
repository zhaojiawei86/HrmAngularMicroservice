using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Hrm.Interview.Infrastructure.Data
{
	public class DapperDbContext
    {
        private readonly IDbConnection dbConnection;
        private readonly IConfiguration configuration;

        public DapperDbContext(IConfiguration _configuration)
        {
            configuration = _configuration;
            var connectionString = configuration.GetConnectionString("HrmInterviewDbDocker");
            dbConnection = new SqlConnection(connectionString);
        }

        public IDbConnection GetConnection()
        {
            return dbConnection;
        }
    }
}

