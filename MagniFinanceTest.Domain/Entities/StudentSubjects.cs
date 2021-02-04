using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagniFinanceTest.Domain.Entities
{
	public class StudentSubjects
	{
		public int StudentSubjectsId { get; set; }
		public int CourseSubjectId { get; set; }
		public int StudentId { get; set; }
		public decimal Grade { get; set; }
		public CourseSubjects CourseSubjects { get; set; }
		public Student Student { get; set; }
	}
}
