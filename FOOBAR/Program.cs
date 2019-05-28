using System;

namespace FooBar
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
						if (num % 3 == 0)
						{
							Console.WriteLine("FOO");
						}
						if (num % 5 == 0)
						{
							Console.WriteLine("BAR");
						}
						if ((num % 3 != 0) && (num % 5 != 0))
						{
							Console.WriteLine(num);
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
