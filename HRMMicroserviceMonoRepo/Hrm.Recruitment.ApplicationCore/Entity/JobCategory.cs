using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Recruitment.ApplicationCore.Entity
{
	public class JobCategory
	{
        public int Id { get; set; }
    
        [Required, Column(TypeName = "varchar(100)")]
        public string Title { get; set; }

        public bool IsActive { get; set; }
    }
}

