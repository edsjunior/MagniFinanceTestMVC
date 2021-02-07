using MagniFinanceTest.Domain.Entities;
using System.Collections.Generic;

namespace MagniFinanceTest.Domain.Interfaces.Services

{
	public interface ICourseSubjectsService : IServiceBase<CourseSubjects>
	{
		IEnumerable<CourseSubjects> FindByCourseId(int id);

		double AverageByCourse(int id);
	}
}
