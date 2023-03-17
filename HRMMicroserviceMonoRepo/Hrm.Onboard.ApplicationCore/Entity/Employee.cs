using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Onboard.ApplicationCore.Entity
{
	public class Employee
	{
        public int Id { get; set; }

        [Required, Column(TypeName = "varchar(20)")]
        public string FirstName { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string? MiddleName { get; set; }

        [Required,Column(TypeName = "varchar(20)")]
        public string LastName { get; set; }

        [Required, Column(TypeName = "varchar(20)")]
        public string SSN { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime HireDate { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [Required]
        public int EmployeeCategoryId { get; set; }

        [Required]
        public int EmployeeStatusId { get; set; }

        [Required, Column(TypeName = "varchar(100)")]
        public string Address { get; set; }

        [Required, Column(TypeName = "varchar(70)"), DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public int EmployeeRoleId { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime DOB { get; set; }
   
        [Required,Column(TypeName = "varchar(10)"), DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }


        // navi props
        public EmployeeRole EmployeeRole { get; set; }
        public EmployeeCategory EmployeeCategory { get; set; }
        public EmployeeStatus EmployeeStatus { get; set; }
    }
}

