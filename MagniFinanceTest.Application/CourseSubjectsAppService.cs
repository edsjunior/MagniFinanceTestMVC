using MagniFinanceTest.Application.Interface;
using MagniFinanceTest.Domain.Entities;
using MagniFinanceTest.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace MagniFinanceTest.Application
{
	public class CourseSubjectsAppService : AppServiceBase<CourseSubjects>, ICourseSubjectsAppService
	{
		private readonly ICourseSubjectsService _courseSubjectService;

		public CourseSubjectsAppService(ICourseSubjectsService courseSubjectService)
			: base(courseSubjectService)
		{
			_courseSubjectService = courseSubjectService;
		}

		public IEnumerable<CourseSubjects> FindByCourseId(int id)
		{
			return _courseSubjectService.FindByCourseId(id);
		}

		

		public double AverageByCourse(int id)
		{
			return _courseSubjectService.AverageByCourse(id);
		}
	}
}
