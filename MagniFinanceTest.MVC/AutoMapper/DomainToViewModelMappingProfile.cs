using AutoMapper;
using MagniFinanceTest.Domain.Entities;
using MagniFinanceTest.MVC.ViewModels;

namespace MagniFinanceTest.MVC.AutoMapper
{
	public class DomainToViewModelMappingProfile : Profile
	{
		public override string ProfileName
		{
			get { return "ViewModelToDomainMappings"; }
		}

		protected override void Configure()
		{
			Mapper.CreateMap<CourseViewModel, Course > ();
			Mapper.CreateMap<CourseSubjectsViewModel, CourseSubjects>();
			Mapper.CreateMap<PersonViewModel, Person>();
			Mapper.CreateMap<StudentViewModel, Student>();
			Mapper.CreateMap<StudentSubjectsViewModel, StudentSubjects>();
			Mapper.CreateMap<TeacherViewModel, Teacher>();
			Mapper.CreateMap<GradeViewModel, Grade>();
		}
	}
}