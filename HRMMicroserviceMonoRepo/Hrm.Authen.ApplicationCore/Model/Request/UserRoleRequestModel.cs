using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Authen.ApplicationCore.Model.Request
{
	public class UserRoleRequestModel
    {
        public int Id { get; set; }
        [Required]
        public int RoleId { get; set; }
        [Required]
        public int AccountId { get; set; }
    }
}

