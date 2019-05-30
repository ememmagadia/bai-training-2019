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
			Console.WriteLine("Enter");
			//var personlist = personList.OfType<Person>();
			//foreach (var person in personlist)
			//{
			//	Console.WriteLine(person.Name, person.Age, person.Gender, person.Address);
			//}

		}
	}
}
