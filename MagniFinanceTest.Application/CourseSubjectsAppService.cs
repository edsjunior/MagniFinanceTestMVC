using MagniFinanceTest.Application.Interface;
using MagniFinanceTest.Domain.Entities;
using MagniFinanceTest.Domain.Interfaces.Services;

namespace MagniFinanceTest.Application
{
	public class CourseSubjectsAppService : AppServiceBase<CourseSubjects>, ICourseSubjectsAppService
	{
		private readonly ICourseSubjectsService _courseService;

		public CourseSubjectsAppService(ICourseSubjectsService courseService)
			: base(courseService)
		{
			_courseService = courseService;
		}
	}
}
