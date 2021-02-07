using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MagniFinanceTest.MVC.ViewModels
{
	public class StudentViewModel
	{
		[Key]
		public int StudentId { get; set; }

		[Required(ErrorMessage = "Name is required")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Birthday is required")]
		[DataType(DataType.Date)]
		public DateTime Birthday { get; set; }

		[Required(ErrorMessage = "Registration number is required")]
		[DisplayName("Registration Number")]
		public int RegistrationNumber { get; set; }
		[Required(ErrorMessage = "Course is required")]
		public int CourseId { get; set; }
		public virtual CourseViewModel Course { get; set; }

		public bool Active { get; set; }
		public DateTime Created { get; set; }

		public virtual double Average { get; set; }

		/*public int StudentSubjectsId { get; set; }*/
		public virtual IEnumerable<StudentSubjectsViewModel> StudentSubjects { get; set; }
	}
}