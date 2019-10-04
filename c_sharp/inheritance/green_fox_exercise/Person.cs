using System;
using System.Collections.Generic;
using System.Text;

namespace green_fox_exercise
{
	class Person
	{
		public string Name { get; set; }
		public string Gender { get; set; }
		public int Age { get; set; }

		public Person(string name = "Jane Doe", string gender = "Female", int age = 30)
		{
			this.Name = name;
			this.Gender = gender;
			this.Age = age;
		}

		public virtual void Introduce()
		{
			Console.WriteLine("Hi, I'm " + Name + ", and I am a " + Age + " year old " + Gender + ".");
		}

		public virtual void GetGoal()
		{
			Console.WriteLine("My goal is: Live for the moment!");
		}
	}
		class Student : Person
		{
			public string PreviousOrganization { get; set; }
			public int SkippedDays { get; set; }

			public Student(string name = "Jane Doe", string gender = "Female", int age = 30, string previousOrganization = "The School of Life", int skippedDays = 0) : base(name, gender, age)
			{
				this.PreviousOrganization = previousOrganization;
				this.SkippedDays = skippedDays;
			}

			public override void Introduce()
			{
				Console.WriteLine("Hi, I'm " + Name + ", and I am a " + Age + " year old " + Gender + " from " + PreviousOrganization + " who skipped " + SkippedDays + " days from the course already.");
			}

			public override void GetGoal()
			{
				Console.WriteLine("Be a junior software developer");
			}

			public void SkipDays(int numberOfDays)
			{
				SkippedDays += numberOfDays;
			}
		}

		class Mentor : Person
		{
			public string Level { get; set; }

			public Mentor(string name = "Jane Doe", string gender = "Female", int age = 30, string level = "Intermediate") : base(name, gender, age)
			{
				this.Level = level;
			}

			public override void Introduce()
			{
				Console.WriteLine("Hi, I'm " + Name + ", and I am a " + Age + " year old " + Gender + " working at an " + Level + " level.");
			}

			public override void GetGoal()
			{
				Console.WriteLine("Educate brilliant junior software developers.");
			}
		}

		class Sponsor : Person
		{
			public string Company { get; set; }
			public int HiredStudents { get; set; }

			public Sponsor(string name = "Jane Doe", string gender = "Female", int age = 30, string company = "Google", int hiredStudents = 0) : base(name, gender, age)
			{
				this.Company = company;
				this.HiredStudents = hiredStudents;
			}

			public override void Introduce()
			{
				Console.WriteLine("Hi, I'm " + Name + ", and I am a " + Age + " year old " + Gender + " who represents " + Company + " and hired " + HiredStudents + " so far.");
			}

			public override void GetGoal()
			{
				Console.WriteLine("Hire brilliant junior software developers.");
			}

			public void Hire()
			{
				HiredStudents += 1;
			}
		}
	}
