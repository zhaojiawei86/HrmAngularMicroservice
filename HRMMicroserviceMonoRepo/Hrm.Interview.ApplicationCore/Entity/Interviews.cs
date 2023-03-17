using System;
using System.ComponentModel.DataAnnotations;

namespace Hrm.Interview.ApplicationCore.Entity
{
	public class Interviews
	{
        public int Id { get; set; }

        [Required]
        public int RecruiterId { get; set; }

        [Required]
        public int SubmissionId { get; set; }

        [Required]
        public int InterviewTypeId { get; set; }

        [Required]
        public int InterviewRound { get; set; }

        public DateTime InterviewDate { get; set; }

        [Required]
        public int InterviewerId { get; set; }

        public int? InterviewFeedbackId { get; set; }


        // navi props
        public InterviewType InterviewType { get; set; }
        public Interviewer Interviewer { get; set; }
        public InterviewFeedback InterviewFeedback { get; set; }
        public Recruiter Recruiter { get; set; }
    }
}

