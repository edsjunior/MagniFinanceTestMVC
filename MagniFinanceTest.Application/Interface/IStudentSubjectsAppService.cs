using MagniFinanceTest.Domain.Entities;
using System.Collections.Generic;

namespace MagniFinanceTest.Application.Interface
{
	public interface IStudentSubjectsAppService : IAppServiceBase<StudentSubjects>
	{
		IEnumerable<StudentSubjects> FindBySubjectId(int id);

		IEnumerable<StudentSubjects> FindByStudentId(int id);
	}
}
