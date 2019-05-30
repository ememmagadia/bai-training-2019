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
			Console.Write("A\tPerson\nB\tMovie\nChoice : ");
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
					Console.Write("Search:\nA\tby Name\nB\tbyAge\nC\tGender\nChoice :");
					string search = Console.ReadLine();
					Console.Write("Enter : ");
					string item = Console.ReadLine();
					person.toView(personList, item, search);

				}
			}

			else if(choice1 == "B")
			{
				Movie movie = new Movie();
				ArrayList movieList = new ArrayList()
					{
						new Movie
						{
							Title = "Mr. Bean",
							Country = "England",
							Year = "2001",
							LeadActor = "Rowan Atkinson",
							Genre = "Comedy"
						},
						new Movie
						{
							Title = "The Nun",
							Country = "United States",
							Year = "2018",
							LeadActor = "Taissa Farmiga",
							Genre = "Horror"
						},
						new Movie
						{
							Title = "The Notebook",
							Country = "Canada",
							Year = "2004",
							LeadActor = "Ryan Gosling",
							Genre = "Romance"
						},
						new Movie
						{
							Title = "Jurassic World",
							Country = "United States",
							Year = "2015",
							LeadActor = "Chris Pratt",
							Genre = "Adventure"
						}

				};
				if (choice2 == "A")
				{
					movie.toViewAll(movieList);
				}
				if (choice2 == "B")
				{
					Console.Write("Search:\nA\tby Title\nB\tbyYear\nC\tGenre\nChoice :");
					string search = Console.ReadLine();
					Console.Write("Enter : ");
					string item = Console.ReadLine();
					movie.toView(movieList, item, search);

				}
			}




		}
		
		
	}
}
