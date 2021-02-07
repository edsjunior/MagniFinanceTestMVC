using MagniFinanceTest.Domain.Entities;
using System.Collections.Generic;

namespace MagniFinanceTest.Application.Interface
{
	public interface ICourseSubjectsAppService : IAppServiceBase<CourseSubjects>
	{
		IEnumerable<CourseSubjects> FindByCourseId(int id);

		
		double AverageByCourse(int id);
	}
}
