using System;
using System.ComponentModel.DataAnnotations;

namespace MagniFinanceTest.MVC.ViewModels
{
	public class TeacherViewModel
	{
		[Key]
		public int TeacherId { get; set; }

		[Required(ErrorMessage = "Name is required")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Birthday is required")]
		[DataType(DataType.Date)]
		[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
		public DateTime Birthday { get; set; }

		[DataType(DataType.Currency)]
		[Range(typeof(decimal), "0", "999999999999")]
		[Required(ErrorMessage = "Salary is required")]
		public decimal Salary { get; set; }

		public bool Active { get; set; }
		public DateTime Created { get; set; }

		public int CourseSubjectId { get; set; }
		public virtual CourseSubjectsViewModel CourseSubjects { get; set; }

	}
}