using System;
using Hrm.Recruitment.ApplicationCore.Contract.Repository;
using Hrm.Recruitment.ApplicationCore.Entity;
using Hrm.Recruitment.Infrastructure.Data;

namespace Hrm.Recruitment.Infrastructure.Repository
{
	public class CandidateRepositoryAsync : BaseRepositoryAsync<Candidate>, ICandidateRepositoryAsync
	{
		public CandidateRepositoryAsync(RecruitDbContext _context): base(_context)
		{

		}
		
	}
}

