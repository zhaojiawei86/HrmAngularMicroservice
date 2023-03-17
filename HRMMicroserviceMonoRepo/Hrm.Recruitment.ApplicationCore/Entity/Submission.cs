using System;
using System.ComponentModel.DataAnnotations;

namespace Hrm.Recruitment.ApplicationCore.Entity
{
	public class Submission
	{
        public int Id { get; set; }

        [Required]
        public int CandidateId { get; set; }

        [Required]
        public int JobRequirementId { get; set; }

        public DateTime AppliedDate { get; set; } = DateTime.Now;

        [Required]
        public DateTime ConfirmedOn { get; set; }

        public DateTime RejectedOn { get; set; }

        [Required]
        public int SubmissionStatusId { get; set; }

        // navi props
        public Candidate Candidate { get; set; }
        public JobRequirement JobRequirement { get; set; }
        public SubmissionStatus SubmissionStatus { get; set; }
    }
}

