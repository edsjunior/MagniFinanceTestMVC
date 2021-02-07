using MagniFinanceTest.Domain.Entities;
using System.Collections.Generic;

namespace MagniFinanceTest.Domain.Interfaces.Repositories
{
	public interface IStudentRepository : IRepositoryBase<Student>
	{
		IEnumerable<Student> FindByName(string name);

		double AverageStudent(int id);

		int CountStudentsByCourse(int id);

		
	}
}
