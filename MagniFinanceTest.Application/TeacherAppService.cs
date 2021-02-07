using MagniFinanceTest.Application.Interface;
using MagniFinanceTest.Domain.Entities;
using MagniFinanceTest.Domain.Interfaces.Services;
using System.Collections.Generic;

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

		public int CountTeachersByCourse(int id)
		{
			return _teacherService.CountTeachersByCourse(id);
		}

		
	}
}
