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
			return Db.StudentsSubjects.Where(c => c.StudentId == id).Average(c => c.Grade.GradeValue);
		}

		public int CountStudentsByCourse(int id)
		{
			return Db.Students.Count(c => c.CourseId == id);
		}

		
	}
}
