using MagniFinanceTest.Domain.Entities;
using System.Collections.Generic;

namespace MagniFinanceTest.Application.Interface
{
	public interface IStudentAppService : IAppServiceBase<Student>
	{
		IEnumerable<Student> FindByName(string name);
	}
}
