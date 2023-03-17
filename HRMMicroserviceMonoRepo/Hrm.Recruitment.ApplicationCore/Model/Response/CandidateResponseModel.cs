using System;
using System.ComponentModel.DataAnnotations;

namespace Hrm.Recruitment.ApplicationCore.Model.Response
{
	public class CandidateResponseModel
	{
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string? MiddleName { get; set; }

        public string LastName { get; set; }

        public string Mobile { get; set; }

        public string Email { get; set; }

        public string currentAddress { get; set; }

        public string? ResumeUrl { get; set; }


    }
}

