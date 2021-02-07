using MagniFinanceTest.Domain.Entities;
using System.Collections.Generic;

namespace MagniFinanceTest.Domain.Interfaces.Repositories
{
	public interface ITeacherRepository : IRepositoryBase<Teacher>
	{
		int CountTeachersByCourse(int id);

		
	}
}
