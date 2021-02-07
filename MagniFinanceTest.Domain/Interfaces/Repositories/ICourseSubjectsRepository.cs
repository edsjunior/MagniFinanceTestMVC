using MagniFinanceTest.Domain.Entities;
using System.Collections.Generic;

namespace MagniFinanceTest.Domain.Interfaces.Repositories
{
	public interface ICourseSubjectsRepository : IRepositoryBase<CourseSubjects>
	{
		IEnumerable<CourseSubjects> FindByCourseId(int id);

		

		double AverageByCourse(int id);


	}
}
