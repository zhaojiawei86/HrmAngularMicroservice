using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Onboard.ApplicationCore.Model.Response
{
	public class EmployeeStatusResponseModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string ABBR { get; set; }
    }
}

