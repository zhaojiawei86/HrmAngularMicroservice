using System;
using System.ComponentModel.DataAnnotations;

namespace Hrm.Authen.ApplicationCore.Model.Response
{
	public class AccountResponseModel
	{
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int EmloyeeId { get; set; }

        public string Email { get; set; }

        public string HashPassword { get; set; }

        public string Salt { get; set; }
    }
}

