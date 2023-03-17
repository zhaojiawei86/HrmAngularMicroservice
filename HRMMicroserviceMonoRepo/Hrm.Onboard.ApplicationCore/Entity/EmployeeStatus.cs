using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Onboard.ApplicationCore.Entity
{
	public class EmployeeStatus
	{
        public int Id { get; set; }

        [Required, Column(TypeName = "varchar(100)")]
        public string Title { get; set; }

        [Required, Column(TypeName = "varchar(10)")]
        public string ABBR { get; set; }
    }
}

