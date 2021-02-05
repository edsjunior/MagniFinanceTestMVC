using MagniFinanceTest.Application.Interface;
using MagniFinanceTest.Domain.Entities;
using MagniFinanceTest.Domain.Interfaces.Services;

namespace MagniFinanceTest.Application
{
	public class CourseAppService : AppServiceBase<Course>, ICourseAppService
	{
		private readonly ICourseService _courseAppService;

		public CourseAppService(ICourseService courseService)
			: base(courseService)
		{
			_courseAppService = courseService;
		}
	}
}
