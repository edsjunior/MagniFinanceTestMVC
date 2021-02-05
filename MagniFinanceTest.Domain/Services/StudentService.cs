using MagniFinanceTest.Domain.Entities;
using MagniFinanceTest.Domain.Interfaces.Repositories;
using MagniFinanceTest.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace MagniFinanceTest.Domain.Services
{
	public class StudentService : ServiceBase<Student>, IStudentService
	{
		private readonly IStudentRepository _studentRepository;

		public StudentService(IStudentRepository studentRepository)
			: base(studentRepository)
		{
			_studentRepository = studentRepository;
		}

		public IEnumerable<Student> FindByName(string name)
		{
			return _studentRepository.FindByName(name);

		}
	}
}
