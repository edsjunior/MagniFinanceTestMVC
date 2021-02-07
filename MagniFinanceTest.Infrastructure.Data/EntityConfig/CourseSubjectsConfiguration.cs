
using MagniFinanceTest.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MagniFinanceTest.Infrastructure.Data.EntityConfig
{
	public class CourseSubjectsConfiguration : EntityTypeConfiguration<CourseSubjects>
	{
		public CourseSubjectsConfiguration()
		{
			HasKey(c => c.CourseSubjectsId);

			Property(c => c.Name)
				.IsRequired()
				.HasMaxLength(200);

			HasRequired(c => c.Course)
				.WithMany()
				.HasForeignKey(c => c.CourseId);

			HasRequired(c => c.Teacher)
				.WithMany()
				.HasForeignKey(c => c.TeacherId);

		}
	}
}
