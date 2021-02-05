using MagniFinanceTest.Domain.Entities;
using System.Collections.Generic;

namespace MagniFinanceTest.Domain.Interfaces.Services
{
	public interface IStudentService : IServiceBase<Student>
	{
		IEnumerable<Student> FindByName(string name);
	}
}
