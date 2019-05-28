using System;
using FooBar;

namespace FOOBAR2
{
	class Program
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
						for (int i = 1; i <= num; i++)
						{
							FooBar.Program.foobar(i);
						}

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
	}
}
