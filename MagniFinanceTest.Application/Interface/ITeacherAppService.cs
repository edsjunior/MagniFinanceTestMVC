using MagniFinanceTest.Domain.Entities;
using System.Collections.Generic;

namespace MagniFinanceTest.Application.Interface
{
	public interface ITeacherAppService : IAppServiceBase<Teacher>
	{
		int CountTeachersByCourse(int id);

		
	}
}
