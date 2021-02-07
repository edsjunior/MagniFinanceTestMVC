using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagniFinanceTest.Domain.Entities
{
	public class Teacher
	{
		public int TeacherId { get; set; }
		public string Name { get; set; }
		public DateTime Birthday { get; set; }
		public decimal Salary { get; set; }
		public bool Active { get; set; }
		public DateTime Created { get; set; }

		public int CourseSubjectId { get; set; }
		public virtual CourseSubjects CourseSubjects { get; set; }
	}
}
