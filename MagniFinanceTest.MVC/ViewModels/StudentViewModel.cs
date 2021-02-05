using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MagniFinanceTest.MVC.ViewModels
{
	public class StudentViewModel : PersonViewModel
	{
		[Required(ErrorMessage = "Registration number is required")]
		[DisplayName("Registration Number")]
		public int RegistrationNumber { get; set; }
		[Required(ErrorMessage = "Course is required")]
		public int CourseId { get; set; }
		public CourseViewModel Course { get; set; }
		
		/*public int StudentSubjectsId { get; set; }
		public virtual StudentSubjectsViewModel StudentSubjects { get; set; }*/
	}
}