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
			Console.WriteLine("A\tPerson\nB\tSong\nC\tMovie\nChoice : ");
			choice1 = Console.ReadLine();
			Console.WriteLine("What do you want to do?");
			Console.WriteLine("A\tShow All the list\nB\tShow Specific Item\nChoice : ");
			choice2 = Console.ReadLine();
			
			if(choice1 == "A")
			{
				Person person = new Person();
				
				if (choice2 == "A")
				{
					person.toViewAll();
				}
			}




		}
		
		
	}
}
