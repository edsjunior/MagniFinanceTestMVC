using System;

namespace MagniFinanceTest.Domain.Entities
{
	public abstract class Person
	{
		public int PersonId { get; set; }
		public string Name { get; set; }
		public DateTime Birthday { get; set; }
		public DateTime Created { get; set; }
		public bool Active { get; set; }
	}
}
