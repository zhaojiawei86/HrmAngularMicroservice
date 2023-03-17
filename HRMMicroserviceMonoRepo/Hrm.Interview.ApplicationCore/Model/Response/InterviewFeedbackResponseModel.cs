
using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Interview.ApplicationCore.Model.Request
{
	public class InterviewFeedbackResponseModel
    {
        public int Id { get; set; }

        public int Raring { get; set; }

        public string Comment { get; set; }
    }
}

