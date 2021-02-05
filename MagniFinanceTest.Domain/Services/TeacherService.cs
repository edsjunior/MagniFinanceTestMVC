using MagniFinanceTest.Domain.Entities;
using MagniFinanceTest.Domain.Interfaces.Repositories;
using MagniFinanceTest.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace MagniFinanceTest.Domain.Services
{
	public class TeacherService : ServiceBase<Teacher>, ITeacherService
	{
		private readonly ITeacherRepository _teacherRepository;

		public TeacherService(ITeacherRepository teacherRepository)
			: base(teacherRepository)
		{
			_teacherRepository = teacherRepository;
		}

	}
}
