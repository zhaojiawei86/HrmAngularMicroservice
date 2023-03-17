using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Authen.ApplicationCore.Model.Response
{
	public class UserRoleResponseModel
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int AccountId { get; set; }
    }
}

