using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
	public class Student
	{
		public Student(string name, int age)
		{
			Name = name;
			Age = age;
		}

		public string Name { get; set; }
		public int Age { get; set; }
	}
}
