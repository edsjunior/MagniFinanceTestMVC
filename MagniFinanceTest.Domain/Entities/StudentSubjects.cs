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
		public int GradeId { get; set; }
		public virtual CourseSubjects CourseSubjects { get; set; }
		public virtual Student Student { get; set; }
		public virtual Grade Grade { get; set; }
	}
}
