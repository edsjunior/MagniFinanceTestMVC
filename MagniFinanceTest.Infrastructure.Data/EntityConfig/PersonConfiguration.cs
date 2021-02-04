using MagniFinanceTest.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace MagniFinanceTest.Infrastructure.Data.EntityConfig
{
	public class PersonConfiguration : EntityTypeConfiguration<Person>
	{
		public PersonConfiguration()
		{
			HasKey(c => c.PersonId);
			Property(c => c.Birthday)
				.IsRequired();
			Property(c => c.Name)
				.IsRequired();
		}
	}
}
