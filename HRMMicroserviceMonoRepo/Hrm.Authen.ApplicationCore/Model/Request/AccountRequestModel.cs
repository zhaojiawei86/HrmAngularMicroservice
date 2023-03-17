using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Authen.ApplicationCore.Model.Request
{
	public class AccountRequestModel
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public int EmloyeeId { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string HashPassword { get; set; }

        [Required]
        public string Salt { get; set; }
    }
}

