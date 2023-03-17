using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Recruitment.ApplicationCore.Entity
{
	public class JobRequirement
	{
        public int Id { get; set; }

        [Required, Column(TypeName = "varchar(100)")]
        public string Title { get; set; }

        [Required, Column(TypeName = "varchar(500)")]
        public string Description { get; set; }

        [Required]
        public int NoOfPosition { get; set; }

        [Required]
        public int HiringManagerId { get; set; }

        [Required, Column(TypeName = "varchar(40)")]
        public string HiringManagerName { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        [Required]
        public DateTime ClosedOn { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public bool IsActive { get; set; }
        
        [Required]
        public int JobCategoryId { get; set; }

        // navigational propertis
        public JobCategory JobCategory { get; set; }
    }
}

