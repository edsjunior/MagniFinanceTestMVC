
using MagniFinanceTest.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MagniFinanceTest.Infrastructure.Data.EntityConfig
{
	public class StudentsConfiguration : EntityTypeConfiguration<Student>
	{
		public StudentsConfiguration()
		{
			Property(c => c.RegistrationNumber)
				.IsRequired();
			Property(c => c.CourseId)
				.IsRequired();

			HasRequired(c => c.StudentSubjects)
				.WithMany()
				.HasForeignKey(c => c.SubjectsStudentId);
		}
		
	}
}
