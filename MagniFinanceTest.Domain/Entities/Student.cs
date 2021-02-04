using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagniFinanceTest.Domain.Entities
{
	public class Student : Person
	{
		public int RegistrationNumber { get; set; }
		public int CourseId { get; set; }
		public Course Course { get; set; }
		public int SubjectsStudentId { get; set; }
		public virtual StudentSubjects StudentSubjects { get; set; }

	}
}
