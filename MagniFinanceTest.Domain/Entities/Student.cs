using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagniFinanceTest.Domain.Entities
{
	public class Student
	{
		public int StudentId { get; set; }
		public string Name { get; set; }
		public DateTime Birthday { get; set; }
		public int RegistrationNumber { get; set; }
		public int CourseId { get; set; }
		public virtual Course Course { get; set; }
		public bool Active { get; set; }
		public DateTime Created { get; set; }


	}
}
