
using MagniFinanceTest.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MagniFinanceTest.Infrastructure.Data.EntityConfig
{
	public class StudentsConfiguration : EntityTypeConfiguration<Student>
	{
		public StudentsConfiguration()
		{
			HasKey(c => c.StudentId);
			Property(c => c.RegistrationNumber)
				.IsRequired();
			Property(c => c.CourseId)
				.IsRequired();

		}
		
	}
}
