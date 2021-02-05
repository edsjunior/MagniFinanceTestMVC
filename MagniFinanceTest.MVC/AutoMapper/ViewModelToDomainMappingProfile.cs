using AutoMapper;
using MagniFinanceTest.Domain.Entities;
using MagniFinanceTest.MVC.ViewModels;

namespace MagniFinanceTest.MVC.AutoMapper
{
	public class ViewModelToDomainMappingProfile : Profile
	{
		public override string ProfileName
		{
			get { return "DomainToViewModelMappings"; }
		}

		protected override void Configure()
		{
			Mapper.CreateMap<Course, CourseViewModel>();
			Mapper.CreateMap<CourseSubjects, CourseSubjectsViewModel>();
			Mapper.CreateMap<Person, PersonViewModel>();
			Mapper.CreateMap<Student, StudentViewModel>();
			Mapper.CreateMap<StudentSubjects, StudentSubjectsViewModel>();
			Mapper.CreateMap<Teacher, TeacherViewModel>();
			Mapper.CreateMap<Grade, GradeViewModel>();
		}
	}
}