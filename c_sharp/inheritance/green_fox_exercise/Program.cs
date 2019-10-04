using System;
using System.Collections.Generic;

namespace green_fox_exercise
{
	class Program
	{
		static void Main(string[] args)
		{
			var people = new List<Person>();

			var mark = new Person("Mark", "male", 46);
			people.Add(mark);
			var jane = new Person();
			people.Add(jane);
			var john = new Student("John Doe", "male", 20, "BME");
			people.Add(john);
			var student = new Student();
			people.Add(student);
			var gandhi = new Mentor("Gandhi", "male", 148, "senior");
			people.Add(gandhi);
			var mentor = new Mentor();
			people.Add(mentor);
			var sponsor = new Sponsor();
			people.Add(sponsor);
			var elon = new Sponsor("Elon Musk", "male", 46, "SpaceX");
			people.Add(elon);

			student.SkipDays(3);

			for (int i = 0; i < 5; i++)
			{
				elon.Hire();
			}

			for (int i = 0; i < 3; i++)
			{
				sponsor.Hire();
			}

			foreach (var person in people)
			{
				person.Introduce();
				person.GetGoal();
			}

			Cohort awesome = new Cohort("AWESOME");
			awesome.AddStudent(student);
			awesome.AddStudent(john);
			awesome.AddMentor(mentor);
			awesome.AddMentor(gandhi);
			awesome.Info();
		}
	}
}
