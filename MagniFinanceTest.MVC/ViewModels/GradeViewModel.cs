using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MagniFinanceTest.MVC.ViewModels
{
	public class GradeViewModel
	{
		[Key]
		public int Id { get; set; }
		[Required(ErrorMessage = "Grade value is required")]
		public int GradeValue { get; set; }
	}
}