using System;
using Information_System;
using System.Linq;
using System.Collections;

namespace Information_System
{
	class Program
	{
		static void Main()
		{
			string choice1,choice2;
			Console.Write("A\tPerson\nB\tSong\nC\tMovie\nChoice : ");
			choice1 = Console.ReadLine();
			Console.WriteLine("What do you want to do?");
			Console.Write("A\tShow All the list\nB\tShow Specific Item\nChoice : ");
			choice2 = Console.ReadLine();
			
			if(choice1 == "A")
			{
				Person person = new Person();
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
				if (choice2 == "A")
				{
					person.toViewAll(personList);
				}
				if (choice2 == "B")
				{
					Console.Write("Search:\nA\tby Name\nB\tbyAge\nC\tGender");
					string search = Console.ReadLine();
					Console.Write("Enter : ");
					string item = Console.ReadLine();
					person.toView(personList, item, search);

				}
			}




		}
		
		
	}
}
