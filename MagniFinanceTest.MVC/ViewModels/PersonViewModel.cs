using System;
using System.ComponentModel.DataAnnotations;

namespace MagniFinanceTest.MVC.ViewModels
{
	public class PersonViewModel
	{
		[Key]
		public int PersonId { get; set; }
		
		[Required(ErrorMessage = "Name is required")]
		[MaxLength(150, ErrorMessage = "Maximum {0} characters")]
		[MinLength(5, ErrorMessage = "Minimun {0} characters")]
		public string Name { get; set; }
		
		[Required(ErrorMessage = "Birthday is required")]
		[DataType(DataType.Date)]
		public DateTime Birthday { get; set; }
		
		[ScaffoldColumn(false)]
		public DateTime Created { get; set; }
		
		public bool Active { get; set; }
	}
}