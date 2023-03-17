using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Interview.ApplicationCore.Entity
{
	public class Recruiter
	{
		public int Id { get; set; }

        [Required, Column(TypeName = "varchar(20)")]
        public string FirstName { get; set; }

        [Required, Column(TypeName = "varchar(20)")]
        public string LastName { get; set; }

        [Required]
        public int EmployeeId { get; set; }
	}
}

