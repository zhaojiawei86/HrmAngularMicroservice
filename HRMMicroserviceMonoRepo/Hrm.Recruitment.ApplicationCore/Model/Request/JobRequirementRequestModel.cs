using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Recruitment.ApplicationCore.Model.Request
{
	public class JobRequirementRequestModel
	{
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int NoOfPosition { get; set; }

        [Required]
        public int HiringManagerId { get; set; }

        [Required]
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
    }
}

