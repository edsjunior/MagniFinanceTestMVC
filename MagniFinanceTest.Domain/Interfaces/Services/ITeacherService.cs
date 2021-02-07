using MagniFinanceTest.Domain.Entities;
using System.Collections.Generic;

namespace MagniFinanceTest.Domain.Interfaces.Services
{
	public interface ITeacherService : IServiceBase<Teacher>
	{
		int CountTeachersByCourse(int id);


		
	}
}
