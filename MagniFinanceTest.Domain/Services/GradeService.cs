using MagniFinanceTest.Domain.Entities;
using MagniFinanceTest.Domain.Interfaces.Repositories;
using MagniFinanceTest.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace MagniFinanceTest.Domain.Services
{
	public class GradeService : ServiceBase<Grade>, IGradeService
	{
		private readonly IGradeRepository _gradeRepository;

		public GradeService(IGradeRepository gradeRepository)
			: base(gradeRepository)
		{
			_gradeRepository = gradeRepository;
		}
	}
}
