using MagniFinanceTest.Application.Interface;
using MagniFinanceTest.Domain.Entities;
using MagniFinanceTest.Domain.Interfaces.Services;
using MagniFinanceTest.Domain.Services;

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
	}
}
