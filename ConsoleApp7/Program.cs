using ConsoleApp7;
using System;
using System.Collections.Generic;
using System.Linq;
	
	
		Student[] students =
		{
			new Student("Misha", 16),
			new Student("Sasha", 18),
			new Student("Dasha", 20),
			new Student("Pasha", 15),
			new Student("Vasiliy", 17)
		};

		StudentCard[] studentCards =
		{
			new StudentCard(12562, "Misha", new DateTime(2022, 01,01)),
			new StudentCard(13242, "Sasha", new DateTime(2023, 01,01)),
			new StudentCard(12932, "Vasiliy", new DateTime(2021, 01,01)),
			new StudentCard(12152, "Dmitry", new DateTime(2024, 01,01))
		};

		var studentInfoList = (from student in students
							   join card in studentCards on student.Name equals card.Name
							   where card.EnrollmentDate.Year > 2021 && student.Age > 16
							   select new StudentInfo
							   {
								   Name = student.Name,
								   Id = card.Id,
								   Age = student.Age,
								   EnrollmentYear = card.EnrollmentDate.Year
							   }).ToList();

		foreach (var studentInfo in studentInfoList)
		{
			Console.WriteLine($"Name: {studentInfo.Name}, ID: {studentInfo.Id}, Age: {studentInfo.Age}, Enrollment Year: {studentInfo.EnrollmentYear}");
		}
	

