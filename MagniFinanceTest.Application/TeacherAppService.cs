using MagniFinanceTest.Application.Interface;
using MagniFinanceTest.Domain.Entities;
using MagniFinanceTest.Domain.Interfaces.Services;

namespace MagniFinanceTest.Application
{
	public class TeacherAppService : AppServiceBase<Teacher>, ITeacherAppService
	{
		private readonly ITeacherService _teacherService;

		public TeacherAppService(ITeacherService teacherService)
			: base(teacherService)
		{
			_teacherService = teacherService;

		}

	}
}
