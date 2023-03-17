using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Authen.ApplicationCore.Model.Response
{
	public class RoleResponseModel
	{
        public int Id { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }
    }
}

