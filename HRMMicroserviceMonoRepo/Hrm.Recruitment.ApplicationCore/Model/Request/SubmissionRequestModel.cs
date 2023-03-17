using System;
using System.ComponentModel.DataAnnotations;

namespace Hrm.Recruitment.ApplicationCore.Model.Request
{
	public class SubmissionRequestModel
	{
        public int Id { get; set; }

        [Required]
        public int CandidateId { get; set; }

        [Required]
        public int JobRequirementId { get; set; }

        public DateTime AppliedDate { get; set; } = DateTime.Now;

        [Required]
        public DateTime ConfirmedOn { get; set; }

        [Required]
        public DateTime RejectedOn { get; set; }

        [Required]
        public int SubmissionStatusId { get; set; }
    }
}

