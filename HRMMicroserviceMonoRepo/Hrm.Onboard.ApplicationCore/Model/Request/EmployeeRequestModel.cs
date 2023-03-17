using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Onboard.ApplicationCore.Model.Request
{
	public class EmployeeRequestModel
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string? MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string SSN { get; set; }

        [Required]
        public DateTime HireDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public int EmployeeCategoryId { get; set; }

        [Required]
        public int EmployeeStatusId { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public int EmployeeRoleId { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        [Required]
        public string Phone { get; set; }
    }
}

