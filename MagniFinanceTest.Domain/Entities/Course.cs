using System;
using System.Collections.Generic;

namespace MagniFinanceTest.Domain.Entities
{
	public class Course
	{
		public int CourseId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public bool Active { get; set; }
		public DateTime Created { get; set; }
		public virtual IEnumerable<CourseSubjects> CourseSubjects { get; set; }
	}
}
