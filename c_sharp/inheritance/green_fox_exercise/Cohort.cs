using System;
using System.Collections.Generic;
using System.Text;

namespace green_fox_exercise
{
	class Cohort
	{
		public string Name { get; set; }
		public List<Student> students { get; set; }
		public List<Mentor> mentors { get; set; }

		public Cohort(string name)
		{
			this.Name = name;
			students = new List<Student>();
			mentors = new List<Mentor>();
		}

		public void AddStudent(Student student)
		{
			students.Add(student);
		}

		public void AddMentor(Mentor mentor)
		{
			mentors.Add(mentor);
		}

		public void Info()
		{
			Console.WriteLine("The " + Name + "cohort has " + students.Count + " students and " + mentors.Count + " mentors.");
		}
	}
}
