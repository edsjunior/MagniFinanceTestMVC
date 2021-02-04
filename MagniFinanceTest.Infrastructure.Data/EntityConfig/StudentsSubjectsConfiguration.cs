
using MagniFinanceTest.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MagniFinanceTest.Infrastructure.Data.EntityConfig
{
	public class StudentsSubjectsConfiguration : EntityTypeConfiguration<StudentSubjects>
	{
		public StudentsSubjectsConfiguration()
		{
			HasKey(c => c.StudentSubjectsId);
			Property(c => c.CourseSubjectId)
				.IsRequired();
			Property(c => c.StudentId)
				.IsRequired();

			HasRequired(c => c.CourseSubjects)
				.WithMany()
				.HasForeignKey(c => c.CourseSubjectId);
		}
	}
}
