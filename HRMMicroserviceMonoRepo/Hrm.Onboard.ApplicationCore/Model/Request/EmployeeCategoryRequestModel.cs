using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Onboard.ApplicationCore.Model.Request
{
	public class EmployeeCategoryRequestModel
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string? description { get; set; }

        public bool IsActive { get; set; } = true;
    }
}

