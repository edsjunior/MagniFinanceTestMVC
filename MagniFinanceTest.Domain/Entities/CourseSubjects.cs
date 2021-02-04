using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagniFinanceTest.Domain.Entities
{
	public class CourseSubjects
	{
		public int CourseSubjectsId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int TeacherId { get; set; }
		public virtual Teacher Teacher { get; set; }
		public int CourseId { get; set; }
		public Course Course { get; set; }

		public virtual IEnumerable<StudentSubjects> StudentSubjects { get; set; }

	}
}
