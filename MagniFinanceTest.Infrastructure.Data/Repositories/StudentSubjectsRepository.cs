using MagniFinanceTest.Domain.Entities;
using MagniFinanceTest.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace MagniFinanceTest.Infrastructure.Data.Repositories
{
	public class StudentSubjectsRepository : RepositoryBase<StudentSubjects>, IStudentSubjectsRepository
	{
		public IEnumerable<StudentSubjects> FindByStudentId(int id)
		{
			return Db.StudentsSubjects.Where(c => c.StudentId == id);
		}

		public IEnumerable<StudentSubjects> FindBySubjectId(int id)
		{
			return Db.StudentsSubjects.Where(c => c.CourseSubjectId == id);
		}


	}
}
