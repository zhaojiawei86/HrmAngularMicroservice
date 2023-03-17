using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Recruitment.ApplicationCore.Model.Request
{
	public class JobRequirementResponseModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int NoOfPosition { get; set; }

        public int HiringManagerId { get; set; }

        public string HiringManagerName { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public DateTime ClosedOn { get; set; }

        public DateTime StartDate { get; set; }

        public bool IsActive { get; set; }

        public int JobCategoryId { get; set; }
    }
}

