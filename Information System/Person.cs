using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Information_System;
using System.Collections;

namespace Information_System
{
	public class Person : IAction
	{

		public string Name { get; set; }
		public int Age { get; set; }
		public string Gender { get; set; }
		public string Address { get; set; }

		public Person(string name = "No Name", int age = 0, string gender = "Male", string address = "No Address")
		{
			Name = name;
			Age = age;
			Gender = gender;
			Address = address;
		}

		public void toView()
		{

		}

		
		public void toViewAll()
		{

			ArrayList personList = new ArrayList()
					{
						new Person
						{
							Name = "Juanita Tuft",
							Age = 16,
							Gender = "Female",
							Address = "Mexico"

						},
						new Person
						{
							Name = "Hobert Rudnick",
							Age = 20,
							Gender = "Male",
							Address = "Las vegas, Nevada"

						},
						new Person
						{
							Name = "Katrice Jonas",
							Age = 23,
							Gender = "Female",
							Address = "Canada"

						},
						new Person
						{
							Name = "Nicholas Badillo",
							Age = 19,
							Gender = "Male",
							Address = "New York"

						}
				};
			var personlist = personList.OfType<Person>();
			foreach (var person in personlist)
			{
				Console.WriteLine(person.Name, person.Age, person.Gender, person.Address);
				Console.ReadKey();
			}

		}
	}
}
