using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MagniFinanceTest.MVC.ViewModels
{
	public class CourseSubjectsViewModel
	{
		[Key]
		public int CourseSubjectsId { get; set; }
		
		[Required(ErrorMessage = "Name is required")]
		[MaxLength(150, ErrorMessage = "Maximum {0} characters")]
		[MinLength(5, ErrorMessage = "Minimun {0} characters")]
		public string Name { get; set; }
		
		[MaxLength(500, ErrorMessage = "Maximum {0} characters")]
		public string Description { get; set; }
		
		[Required(ErrorMessage = "Teacher is required")]
		public int TeacherId { get; set; }
		
		public virtual TeacherViewModel Teacher { get; set; }

		[Required(ErrorMessage = "Course is required")]
		public int CourseId { get; set; }
		
		public virtual CourseViewModel Course { get; set; }

		public virtual IEnumerable<StudentSubjectsViewModel> StudentSubjects { get; set; }
	}
}