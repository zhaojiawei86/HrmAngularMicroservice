
using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Interview.ApplicationCore.Model.Request
{
	public class InterviewFeedbackRequestModel
    {
        public int Id { get; set; }

        [Required]
        public int Raring { get; set; }

        [Required]
        public string Comment { get; set; }
    }
}

