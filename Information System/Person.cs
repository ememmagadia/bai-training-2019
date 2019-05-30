using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Information_System;
using System.Collections;

namespace Information_System
{
	public class Person
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

		public void toView(ArrayList personList, string item, string choice)
		{
			var personListenum = personList.OfType<Person>();
			switch(choice)
			{
				case "A":
					var result = from person in personListenum where person.Name == item select person;
					foreach (var person in result)
					{
						Console.WriteLine("Name : {0}\nAge : {1}\nGender : {2}\nAddress : {3}", person.Name, person.Age, person.Gender, person.Address);
					}
					Console.ReadKey();
					break;
				case "B":
					int item1 = Convert.ToInt32(item);
					result = from person in personListenum where person.Age == item1 select person;
					foreach (var person in result)
					{
						Console.WriteLine("Name : {0}\nAge : {1}\nGender : {2}\nAddress : {3}", person.Name, person.Age, person.Gender, person.Address);
					}
					Console.ReadKey();
					break;
				case "C":
					result = from person in personListenum where person.Gender == item select person;
					foreach (var person in result)
					{
						Console.WriteLine("Name : {0}\nAge : {1}\nGender : {2}\nAddress : {3}\n", person.Name, person.Age, person.Gender, person.Address);
					}
					Console.ReadKey();
					break;
			}

			
		}

		
		public void toViewAll(ArrayList personList)
		{
			var personlist = personList.OfType<Person>();
			foreach (var person in personlist)
			{
				Console.WriteLine("Name : {0}\nAge : {1}\nGender : {2}\nAddress : {3}", person.Name , person.Age , person.Gender , person.Address);
			}
			Console.ReadKey();
		}
	}
}
