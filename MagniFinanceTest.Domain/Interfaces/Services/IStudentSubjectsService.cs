using MagniFinanceTest.Domain.Entities;
using System.Collections.Generic;

namespace MagniFinanceTest.Domain.Interfaces.Services
{
	public interface IStudentSubjectsService : IServiceBase<StudentSubjects>
	{
		IEnumerable<StudentSubjects> FindBySubjectId(int id);

		IEnumerable<StudentSubjects> FindByStudentId(int id);
	}
}
