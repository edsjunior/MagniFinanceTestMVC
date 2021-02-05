using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MagniFinanceTest.MVC.ViewModels
{
	public class CourseViewModel
	{
		[Key]
		public int CourseId { get; set; }
		
		[Required(ErrorMessage = "Name is required")]
		[MaxLength(150, ErrorMessage = "Maximum {0} characters")]
		[MinLength(5, ErrorMessage = "Minimun {0} characters")]
		public string Name { get; set; }
		
		[MaxLength(500, ErrorMessage = "Maximum {0} characters")]
		public string Description { get; set; }
		
		public bool Active { get; set; }
		
		[ScaffoldColumn(false)]
		public DateTime Created { get; set; }

		public virtual IEnumerable<CourseSubjectsViewModel> CourseSubjects { get; set; }
	}
}