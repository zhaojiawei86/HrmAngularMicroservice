using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Interview.ApplicationCore.Entity
{
	public class InterviewType
	{
        public int Id { get; set; }

        [Required, Column(TypeName = "varchar(100)")]
        public string Title { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}

