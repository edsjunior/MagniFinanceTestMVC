
using MagniFinanceTest.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MagniFinanceTest.Infrastructure.Data.EntityConfig
{
	public class CourseConfiguration: EntityTypeConfiguration<Course>
	{
		public CourseConfiguration()
		{
			HasKey(c => c.CourseId);
			
			Property(c => c.Name)
				.IsRequired();

			Property(c => c.Description)
				.HasMaxLength(500);
		}
	}
}
