using System.ComponentModel.DataAnnotations;

namespace MagniFinanceTest.MVC.ViewModels
{
	public class TeacherViewModel : PersonViewModel
	{
		[DataType(DataType.Currency)]
		[Range(typeof(decimal), "0", "999999999999")]
		[Required(ErrorMessage = "Salary is required")]
		public decimal Salary { get; set; }
		
	}
}