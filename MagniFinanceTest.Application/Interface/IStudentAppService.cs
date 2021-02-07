using MagniFinanceTest.Domain.Entities;
using System.Collections.Generic;

namespace MagniFinanceTest.Application.Interface
{
	public interface IStudentAppService : IAppServiceBase<Student>
	{
		IEnumerable<Student> FindByName(string name);
		double AverageStudent(int id);

		int CountStudentsByCourse(int id);

		
	}
}
