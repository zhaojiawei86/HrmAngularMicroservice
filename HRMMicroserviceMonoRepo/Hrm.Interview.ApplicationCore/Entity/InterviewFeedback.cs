using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Interview.ApplicationCore.Entity
{
	public class InterviewFeedback
	{
        public int Id { get; set; }

        [Required]
        public int Raring { get; set; }

        [Required, Column(TypeName = "varchar(1000)")]
        public string Comment { get; set; }
    }
}

