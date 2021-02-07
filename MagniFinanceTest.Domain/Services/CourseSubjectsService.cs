using MagniFinanceTest.Domain.Entities;
using MagniFinanceTest.Domain.Interfaces.Repositories;
using MagniFinanceTest.Domain.Interfaces.Services;
using System.Collections.Generic;

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

		public IEnumerable<CourseSubjects> FindByCourseId(int id)
		{
			return _courseSubjectRepository.FindByCourseId(id);
		}

		

		public double AverageByCourse(int id)
		{
			return _courseSubjectRepository.AverageByCourse(id);
		}
	}

	
}
