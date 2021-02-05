using MagniFinanceTest.Domain.Entities;
using MagniFinanceTest.Domain.Interfaces.Repositories;
using MagniFinanceTest.Domain.Interfaces.Services;

namespace MagniFinanceTest.Domain.Services
{
	public class CourseService : ServiceBase<Course>, ICourseService
	{
		private readonly ICourseRepository _courseRepository;

		public CourseService(ICourseRepository courseRepository)
			: base(courseRepository)
		{
			_courseRepository = courseRepository;
		}
	}
}
