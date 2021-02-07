using MagniFinanceTest.Application.Interface;
using MagniFinanceTest.Domain.Entities;
using MagniFinanceTest.Domain.Interfaces.Services;
using MagniFinanceTest.Domain.Services;
using System.Collections.Generic;

namespace MagniFinanceTest.Application
{
	public class StudentsSubjectsAppService : AppServiceBase<StudentSubjects>, IStudentSubjectsAppService
	{
		private readonly IStudentSubjectsService _studentSubject;

		public StudentsSubjectsAppService(IStudentSubjectsService studentsSubjects)
			: base(studentsSubjects)
		{
			_studentSubject = studentsSubjects;
		}

		public IEnumerable<StudentSubjects> FindBySubjectId(int id)
		{
			return _studentSubject.FindBySubjectId(id);
		}

		public IEnumerable<StudentSubjects> FindByStudentId(int id)
		{
			return _studentSubject.FindByStudentId(id);
		}

	}
}
