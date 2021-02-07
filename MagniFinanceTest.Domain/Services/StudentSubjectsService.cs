using MagniFinanceTest.Domain.Entities;
using MagniFinanceTest.Domain.Interfaces.Repositories;
using MagniFinanceTest.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace MagniFinanceTest.Domain.Services
{
	public class StudentSubjectsService : ServiceBase<StudentSubjects>, IStudentSubjectsService
	{
		private readonly IStudentSubjectsRepository _studentSubjectsRepository;

		public StudentSubjectsService(IStudentSubjectsRepository studentSubjectsRepository)
			: base(studentSubjectsRepository)
		{
			_studentSubjectsRepository = studentSubjectsRepository;
		}
		public IEnumerable<StudentSubjects> FindBySubjectId(int id)
		{
			return _studentSubjectsRepository.FindBySubjectId(id);
		}

		public IEnumerable<StudentSubjects> FindByStudentId(int id)
		{
			return _studentSubjectsRepository.FindByStudentId(id);
		}
		
	}
}
