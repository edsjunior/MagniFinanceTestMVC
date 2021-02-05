using MagniFinanceTest.Domain.Entities;
using MagniFinanceTest.Domain.Interfaces.Repositories;
using MagniFinanceTest.Domain.Interfaces.Services;

namespace MagniFinanceTest.Domain.Services
{
	public class CourseSubjectsService : ServiceBase<CourseSubjects>, ICourseSubjectsService
	{
		private readonly ICourseSubjectsRepository _courseSubjectRepository;

		public CourseSubjectsService(ICourseSubjectsRepository courseSubjectsRepository)
			: base(courseSubjectsRepository)
		{
			_courseSubjectRepository = courseSubjectsRepository;
		}
	}

	
}
