using System;
using System.ComponentModel.DataAnnotations;

namespace Hrm.Authen.ApplicationCore.Entity
{
	public class UserRole
	{
		public int Id { get; set; }
		[Required]
		public int RoleId { get; set; }
        [Required]
        public int AccountId { get; set; }

		// navi props
		public Role Role { get; set; }
		public Account Account { get; set; }
	}
}

