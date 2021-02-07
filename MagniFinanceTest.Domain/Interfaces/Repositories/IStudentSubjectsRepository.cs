using MagniFinanceTest.Domain.Entities;
using System.Collections.Generic;

namespace MagniFinanceTest.Domain.Interfaces.Repositories
{
	public interface IStudentSubjectsRepository : IRepositoryBase<StudentSubjects>
	{
		IEnumerable<StudentSubjects> FindBySubjectId(int id);

		IEnumerable<StudentSubjects> FindByStudentId(int id);
	}
}
