namespace MagniFinanceTest.Infrastructure.Data.Migrations
{
	using MagniFinanceTest.Domain.Entities;
	using System;
	using System.Collections.Generic;
	using System.Data.Entity.Migrations;

	internal sealed class Configuration : DbMigrationsConfiguration<Context.MagniFinanceContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = true;
		}

		protected override void Seed(Context.MagniFinanceContext context)
		{
			//  This method will be called after migrating to the latest version.

			//  You can use the DbSet<T>.AddOrUpdate() helper extension method
			//  to avoid creating duplicate seed data.

			var courses = new List<Course>
			{
				new Course {CourseId = 1, Name = "Biology",      Description = "This course includes a study of living organisms and vital processes. Themes that will be covered in this course include scientific skills, ecology, biochemistry, cellular processes, genetics, evolution, classification of organisms, as well as plant and human body systems.", Active = true, Created = DateTime.Now },
				new Course {CourseId = 2, Name = "Chemistry",      Description = "Introduction to the general principles of chemistry for students planning a professional career in chemistry, a related science, the health professions, or engineering. Stoichiometry, atomic structure, chemical bonding and geometry, thermochemistry, gases, types of chemical reactions, statistics.", Active = true, Created = DateTime.Now },
				new Course {CourseId = 3, Name = "Literature",      Description = "An introduction to reading and analyzing these primary genres of literature: fiction, poetry, and drama. The course may also include creative nonfiction. Students will respond critically to readings of different historical and cultural contexts through class discussion and written evidence-based literary arguments.", Active = true, Created = DateTime.Now },
				new Course {CourseId = 4, Name = "Computer Science",      Description = "Introduction to computer science and the study of algorithms; foundational ideas, computer organization, software concepts (e.g., networking, databases, security); programming concepts using Python.", Active = true, Created = DateTime.Now },
				new Course {CourseId = 5, Name = "Human Resources",      Description = "Human Resource Management links people-related activities to business strategy. The course develops a critical understanding of the role and functions of the various human resource activities in an organisation, providing students with a comprehensive review of key HRM concepts, techniques and issues.", Active = true, Created = DateTime.Now },
				new Course {CourseId = 6, Name = "Adminstration",      Description = "Administrative courses such as this provide an overview of the skills students need to work in a professional office environment, including planning meetings, arranging travel plans, budgeting and managing others. ... Students use different computer software programs and develop basic technological skills.", Active = true, Created = DateTime.Now },
			};
			courses.ForEach(s => context.Courses.AddOrUpdate(p => p.CourseId, s));
			context.SaveChanges();

			var students = new List<Student>
			{
				new Student {StudentId = 1, Name = "Michael Scott",   RegistrationNumber = 1421, Birthday = DateTime.Parse("1970-09-01"), CourseId = 6, Active= true, Created = DateTime.Now },
				new Student {StudentId = 2, Name = "Dwight Schrute",   RegistrationNumber = 1422, Birthday = DateTime.Parse("1980-04-05"), CourseId = 1, Active= true, Created = DateTime.Now },
				new Student {StudentId = 3, Name = "Jim Halpert",   RegistrationNumber = 1551, Birthday = DateTime.Parse("1985-12-01"), CourseId = 2, Active= true, Created = DateTime.Now },
				new Student {StudentId = 4, Name = "Pam Beesly",   RegistrationNumber = 1617, Birthday = DateTime.Parse("1988-04-08"), CourseId = 3, Active= true, Created = DateTime.Now },
				new Student {StudentId = 5, Name = "Ryan Howard",   RegistrationNumber = 2231, Birthday = DateTime.Parse("1990-10-12"), CourseId = 4, Active= true, Created = DateTime.Now },
				new Student {StudentId = 6, Name = "Andy Bernard",   RegistrationNumber = 4587, Birthday = DateTime.Parse("1984-11-07"), CourseId = 3, Active= true, Created = DateTime.Now },
				new Student {StudentId = 7, Name = "Jan Levinson",   RegistrationNumber = 2365, Birthday = DateTime.Parse("2010-05-02"), CourseId = 5, Active= true, Created = DateTime.Now },
			};
			students.ForEach(s => context.Students.AddOrUpdate(p => p.StudentId, s));
			context.SaveChanges();

			var teachers = new List<Teacher>
			{
				new Teacher {TeacherId = 1, Name = "Roy Anderson",   Salary = 9000, Birthday = DateTime.Parse("1970-09-29"),  Active= true, Created = DateTime.Now },
				new Teacher {TeacherId = 2, Name = "Stanley Hudson",   Salary = 8000, Birthday = DateTime.Parse("1980-04-19"), Active= true, Created = DateTime.Now },
				new Teacher {TeacherId = 3, Name = "Kevin Malone",   Salary = 7000, Birthday = DateTime.Parse("1985-12-11"), Active= true, Created = DateTime.Now },
				new Teacher {TeacherId = 4, Name = "Meredith Palmer",   Salary = 7000, Birthday = DateTime.Parse("1988-04-15"), Active= true, Created = DateTime.Now },
				new Teacher {TeacherId = 5, Name = "Angela Martin",   Salary = 3000, Birthday = DateTime.Parse("1990-10-28"), Active= true, Created = DateTime.Now },
				new Teacher {TeacherId = 6, Name = "Oscar Martinez",   Salary = 5000, Birthday = DateTime.Parse("1984-11-14"), Active= true, Created = DateTime.Now },
				new Teacher {TeacherId = 7, Name = "Phyllis Vance",   Salary = 11000, Birthday = DateTime.Parse("2010-05-20"), Active= true, Created = DateTime.Now },
			};
			teachers.ForEach(s => context.Teachers.AddOrUpdate(p => p.TeacherId, s));
			context.SaveChanges();

			var subjects = new List<CourseSubjects>
			{
				new CourseSubjects {CourseSubjectsId = 1, Name = "Algorithms",   Description = "", CourseId = 4, TeacherId = 2 },
				new CourseSubjects {CourseSubjectsId = 2, Name = "Atomic Structure",   Description = "", CourseId = 2, TeacherId = 3 },
				new CourseSubjects {CourseSubjectsId = 3, Name = "Modern age",   Description = "", CourseId = 3, TeacherId = 6 },
				new CourseSubjects {CourseSubjectsId = 4, Name = "Genetics",   Description = "", CourseId = 1, TeacherId = 5 },
				new CourseSubjects {CourseSubjectsId = 5, Name = "Databases",   Description = "",  CourseId = 4, TeacherId = 2 },
				new CourseSubjects {CourseSubjectsId = 6, Name = "Communication",   Description = "", CourseId = 6, TeacherId = 4 },
				new CourseSubjects {CourseSubjectsId = 7, Name = "Behavioral science",   Description = "", CourseId = 5, TeacherId = 1 },
				new CourseSubjects {CourseSubjectsId = 8, Name = "Thermochemistry",   Description = "", CourseId = 2, TeacherId = 3 }
			};
			subjects.ForEach(s => context.CourseSubjects.AddOrUpdate(p => p.CourseSubjectsId, s));
			context.SaveChanges();

			var grades = new List<Grade>
			{
				new Grade {GradeId = 1, GradeValue = 0},
				new Grade {GradeId = 2, GradeValue = 1},
				new Grade {GradeId = 3, GradeValue = 2},
				new Grade {GradeId = 4, GradeValue = 3},
				new Grade {GradeId = 5, GradeValue = 4},
				new Grade {GradeId = 6, GradeValue = 5},
				new Grade {GradeId = 7, GradeValue = 6},
				new Grade {GradeId = 8, GradeValue = 7},
				new Grade {GradeId = 9, GradeValue = 8},
				new Grade {GradeId = 10, GradeValue = 9},
				new Grade {GradeId = 11, GradeValue = 10}
			};
			grades.ForEach(s => context.Grades.AddOrUpdate(p => p.GradeId, s));
			context.SaveChanges();


			var studentsSubjects = new List<StudentSubjects>
			{
				new StudentSubjects {StudentSubjectsId = 1, GradeId = 1, CourseSubjectId = 6, StudentId = 1},
				new StudentSubjects {StudentSubjectsId = 2, GradeId = 2, CourseSubjectId = 2, StudentId = 2},
				new StudentSubjects {StudentSubjectsId = 3, GradeId = 3, CourseSubjectId = 8, StudentId = 3},
				new StudentSubjects {StudentSubjectsId = 4, GradeId = 4, CourseSubjectId = 3, StudentId = 4},
				new StudentSubjects {StudentSubjectsId = 5, GradeId = 5, CourseSubjectId = 5, StudentId = 5},
				new StudentSubjects {StudentSubjectsId = 6, GradeId = 6, CourseSubjectId = 3, StudentId = 6},
				new StudentSubjects {StudentSubjectsId = 7, GradeId = 7, CourseSubjectId = 7, StudentId = 7},
				new StudentSubjects {StudentSubjectsId = 8, GradeId = 8, CourseSubjectId = 7, StudentId = 7},
				new StudentSubjects {StudentSubjectsId = 9, GradeId = 9, CourseSubjectId = 3, StudentId = 6},
				new StudentSubjects {StudentSubjectsId = 10, GradeId = 10, CourseSubjectId = 5, StudentId = 5},
				new StudentSubjects {StudentSubjectsId = 11, GradeId = 1, CourseSubjectId = 3, StudentId = 4},
				new StudentSubjects {StudentSubjectsId = 12, GradeId = 2, CourseSubjectId = 8, StudentId = 3},
				new StudentSubjects {StudentSubjectsId = 13, GradeId = 3, CourseSubjectId = 1, StudentId = 2},
				new StudentSubjects {StudentSubjectsId = 14, GradeId = 4, CourseSubjectId = 6, StudentId = 1}
			};
			studentsSubjects.ForEach(s => context.StudentsSubjects.AddOrUpdate(p => p.StudentSubjectsId, s));
			context.SaveChanges();


		}
	}
}
