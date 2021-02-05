using MagniFinanceTest.Application.Interface;
using MagniFinanceTest.Domain.Entities;
using MagniFinanceTest.Domain.Interfaces.Services;

namespace MagniFinanceTest.Application
{
	public class GradeAppService : AppServiceBase<Grade>, IGradeAppService
	{
		private readonly IGradeService _gradeService;

		public GradeAppService(IGradeService gradeService)
			: base(gradeService)
		{
			_gradeService = gradeService;

		}
	}
}
