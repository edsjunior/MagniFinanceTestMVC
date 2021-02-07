using MagniFinanceTest.Domain.Entities;
using MagniFinanceTest.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace MagniFinanceTest.Infrastructure.Data.Repositories
{
	public class CourseSubjectsRepository : RepositoryBase<CourseSubjects>, ICourseSubjectsRepository
	{
		public IEnumerable<CourseSubjects> FindByCourseId(int id)
		{
			return Db.CourseSubjects.Where(c => c.CourseId == id);
		}

		public double AverageByCourse(int id)
		{
			var students = Db.Students.Where(c => c.CourseId == id);

			var courseSubjects = FindByCourseId(id);

			foreach (Student item in students)
			{
				return Db.StudentsSubjects.Where(c => c.StudentId == item.StudentId).Average(c => c.Grade.GradeValue);
			}
			return 0;

		}
	}
}
