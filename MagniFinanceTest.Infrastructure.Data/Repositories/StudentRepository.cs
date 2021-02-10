using MagniFinanceTest.Domain.Entities;
using MagniFinanceTest.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace MagniFinanceTest.Infrastructure.Data.Repositories
{
	public class StudentRepository : RepositoryBase<Student>, IStudentRepository
	{
		public IEnumerable<Student> FindByName(string name)
		{
			return Db.Students.Where(p => p.Name == name);
		}

		public double AverageStudent(int id)
		{
			
			IEnumerable<StudentSubjects> evaluation = Db.StudentsSubjects.Where(c => c.StudentId == id);
			if (evaluation.Count() > 0)
			{
				return Db.StudentsSubjects
				.Where(c => c.StudentId == id)
				.Average(c => c.Grade.GradeValue);
			} else
			{
				return 0;
			}
			
		}

		public int CountStudentsByCourse(int id)
		{
			return Db.Students.Count(c => c.CourseId == id);
		}

		
	}
}
