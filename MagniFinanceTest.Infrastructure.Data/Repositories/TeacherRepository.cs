using MagniFinanceTest.Domain.Entities;
using MagniFinanceTest.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace MagniFinanceTest.Infrastructure.Data.Repositories
{
	public class TeacherRepository : RepositoryBase<Teacher>, ITeacherRepository
	{
		public int CountTeachersByCourse(int id)
		{
			var subjects = Db.CourseSubjects.Where(c => c.CourseId == id);

			var teachersCourse = subjects.GroupBy(s => s.TeacherId)
				.Select(s => new
				{
					Teacher = s.Key,
					TeacherCount = s.Count()
				})
				.OrderBy(s => s.Teacher);
			return teachersCourse.Count();

		}

		
	}
}
