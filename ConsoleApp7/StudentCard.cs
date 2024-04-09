using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
	public class StudentCard
	{
		public StudentCard(int id, string name, DateTime enrollmentDate)
		{
			Id = id;
			Name = name;
			EnrollmentDate = enrollmentDate;
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public DateTime EnrollmentDate { get; set; }
	}
}
