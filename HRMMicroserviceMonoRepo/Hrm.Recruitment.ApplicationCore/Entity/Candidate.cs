using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Recruitment.ApplicationCore.Entity
{
    public class Candidate
    {
        public int Id { get; set; }

        [Required, Column(TypeName = "varchar(20)")]
        public string FirstName { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string? MiddleName { get; set; }

        [Required, Column(TypeName = "varchar(20)")]
        public string LastName { get; set; }

        [Required, Column(TypeName = "varchar(15)"), DataType(DataType.PhoneNumber)]
        public string Mobile { get; set; }

        [Required, Column(TypeName = "varchar(50)"), DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, Column(TypeName = "varchar(100)")]
        public string currentAddress { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string? ResumeUrl { get; set; }
    }
}

