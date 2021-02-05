using System;
using System.ComponentModel.DataAnnotations;

namespace MagniFinanceTest.MVC.ViewModels
{
	public class StudentSubjectsViewModel
	{
		[Key]
		public int StudentSubjectsId { get; set; }
		[Required(ErrorMessage = "Course Subject is required")]
		public int CourseSubjectId { get; set; }
		[Required(ErrorMessage = "Student is required")]
		public int StudentId { get; set; }
		public decimal Grade { get; set; }
		public CourseSubjectsViewModel CourseSubjects { get; set; }
		public StudentViewModel Student { get; set; }
	}
}