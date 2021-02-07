using MagniFinanceTest.Application.Interface;
using MagniFinanceTest.Domain.Entities;
using MagniFinanceTest.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace MagniFinanceTest.Application
{
	public class StudentAppService : AppServiceBase<Student>, IStudentAppService
	{
		private readonly IStudentService _studentService;

		public StudentAppService(IStudentService studentAppService)
			: base(studentAppService)
		{
			_studentService = studentAppService;

		}

		public IEnumerable<Student> FindByName(string name)
		{
			return _studentService.FindByName(name);
		}

		public double AverageStudent(int id)
		{
			return _studentService.AverageStudent(id);
		}

		public int CountStudentsByCourse(int id)
		{
			return _studentService.CountStudentsByCourse(id);
		}

		
	}
}
