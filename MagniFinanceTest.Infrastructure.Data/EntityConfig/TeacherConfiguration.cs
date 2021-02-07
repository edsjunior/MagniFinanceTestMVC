using MagniFinanceTest.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MagniFinanceTest.Infrastructure.Data.EntityConfig
{
	public class TeacherConfiguration : EntityTypeConfiguration<Teacher>
	{
		public TeacherConfiguration()
		{

			HasKey(c => c.TeacherId);
			
			Property(c => c.Salary)
				.IsRequired();

			
		}
	}
}
