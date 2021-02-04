using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using MagniFinanceTest.Domain.Entities;
using MagniFinanceTest.Infrastructure.Data.EntityConfig;

namespace MagniFinanceTest.Infrastructure.Data.Context
{
	public class MagniFinanceContext : DbContext
	{
		public MagniFinanceContext()
			: base("MagniFinance")
		{

		}
		public DbSet<Course> Courses { get; set; }
		public DbSet<CourseSubjects> CourseSubjects { get; set; }
		public DbSet<Person> Person { get; set; }
		public DbSet<StudentSubjects> StudentSubjects { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
			modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

			//Set primary Key
			modelBuilder.Properties()
				.Where(p => p.Name == p.ReflectedType.Name + "Id")
				.Configure(p => p.IsKey());

			modelBuilder.Properties<string>()
				.Configure(p => p.HasColumnType("varchar"));

			modelBuilder.Properties<string>()
				.Configure(p => p.HasMaxLength(100));

			modelBuilder.Configurations.Add(new CourseConfiguration());
			modelBuilder.Configurations.Add(new CourseSubjectsConfiguration());
			modelBuilder.Configurations.Add(new PersonConfiguration());
			modelBuilder.Configurations.Add(new StudentsConfiguration());
			modelBuilder.Configurations.Add(new StudentsSubjectsConfiguration());
			modelBuilder.Configurations.Add(new TeacherConfiguration());
		}

		//Save Created date
		public override int SaveChanges()
		{
			foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("Created") != null))
			{
				if (entry.State == EntityState.Added)
				{
					entry.Property("Created").CurrentValue = DateTime.Now;
				}

				if (entry.State == EntityState.Modified)
				{
					entry.Property("Created").IsModified = false;
				}
			}
			return base.SaveChanges();
		}
	}
}
