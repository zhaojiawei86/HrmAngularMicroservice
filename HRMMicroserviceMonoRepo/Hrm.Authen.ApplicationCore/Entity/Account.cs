using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Authen.ApplicationCore.Entity
{
	public class Account
	{
		public int Id { get; set; }

        [Required, Column(TypeName = "varchar(20)")]
        public string FirstName { get; set; }

        [Required, Column(TypeName = "varchar(20)")]
        public string LastName { get; set; }

        [Required]
        public int EmloyeeId { get; set; }

        [Required, Column(TypeName ="varchar(70)"), DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, Column(TypeName = "varchar(100)")]
        public string HashPassword { get; set; }

        [Required, Column(TypeName = "varchar(100)")]
        public string Salt { get; set; }


	}
}