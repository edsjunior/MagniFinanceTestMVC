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
		public int GradeId { get; set; }
		public virtual CourseSubjectsViewModel CourseSubjects { get; set; }
		public virtual StudentViewModel Student { get; set; }
		public virtual GradeViewModel Grade { get; set; }
	}
}