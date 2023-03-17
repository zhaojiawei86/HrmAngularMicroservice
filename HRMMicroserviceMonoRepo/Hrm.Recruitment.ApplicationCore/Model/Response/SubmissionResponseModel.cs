using System;
using System.ComponentModel.DataAnnotations;

namespace Hrm.Recruitment.ApplicationCore.Model.Request
{
	public class SubmissionResponseModel
    {
        public int Id { get; set; }

        public int CandidateId { get; set; }

        public int JobRequirementId { get; set; }

        public DateTime AppliedDate { get; set; } = DateTime.Now;

        public DateTime ConfirmedOn { get; set; }

        public DateTime RejectedOn { get; set; }

        public int SubmissionStatusId { get; set; }
    }
}

