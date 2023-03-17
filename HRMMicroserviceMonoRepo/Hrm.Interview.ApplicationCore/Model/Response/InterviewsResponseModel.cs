
using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Interview.ApplicationCore.Model.Request
{
	public class InterviewsResponseModel
    {
        public int Id { get; set; }

        public int RecruiterId { get; set; }

        public int SubmissionId { get; set; }

        public int InterviewTypeId { get; set; }

        public int InterviewRound { get; set; }

        public DateTime InterviewDate { get; set; }

        public int InterviewerId { get; set; }

        public int? InterviewFeedbackId { get; set; }
    }
}

