﻿using System;

 namespace FooBar
{
	public class Program
	{
		public static void Main()
		{
			string again = "Y";
			while (again == "Y" || again == "y")
			{
				Console.Write("Enter number : ");
				var value = Console.ReadLine();
				int num;
				if (int.TryParse(value, out num))
				{
					num = Convert.ToInt32(value);
					if (num >= 0)
					{
						foobar(num);

						Console.Write("Do you want to try again?? Y/N : ");
						again = Console.ReadLine();
					}
					else
					{
						Console.WriteLine("The number is less than 0.");
						again = "Y";
					}


				}

				else
				{
					Console.WriteLine("Please enter a number.");
					again = "Y";
				}

			}

			Console.ReadKey();

		}

		public static void foobar(int num)
		{
			 if ((num % 5 == 0) && (num % 3 == 0))
			{
				Console.WriteLine("FOOBAR");
			}
			else if(num % 3 == 0)
			{
				Console.WriteLine("FOO");
			}
			else if (num % 5 == 0)
			{
				Console.WriteLine("BAR");
			}
			
			else if ((num % 3 != 0) && (num % 5 != 0))
			{
				Console.WriteLine(num);
			}
		}
	}
}
