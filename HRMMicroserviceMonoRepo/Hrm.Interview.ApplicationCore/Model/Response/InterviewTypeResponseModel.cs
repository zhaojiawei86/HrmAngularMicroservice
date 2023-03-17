using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Interview.ApplicationCore.Model.Response
{
	public class InterviewTypeResponseModel
	{
        public int Id { get; set; }

        public string Title { get; set; }

        public bool IsActive { get; set; }
    }
}

