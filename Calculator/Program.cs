using System;

namespace Calculator
{
	abstract class numbers
	{
		public int firstnum;
		public int secondnum;
		public abstract int result();

	}
	class Add : numbers
	{
		public override int result()
		{
			return (firstnum + secondnum) ;
		}
	}

	class Subtract : numbers
	{
		public override int result()
		{
			return (firstnum - secondnum);
		}
	}
	class Divide : numbers
	{
		public override int result()
		{
			return (firstnum / secondnum);
		}
	}
	class Multiply : numbers
	{
		public override int result()
		{
			return (firstnum * secondnum);
		}
	}
	public class Program
	{
		public static void Main(string[] args)
		{
			int first, second;
			string operation;
			Console.Write("Enter First number: ");
			first = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter Second number: ");
			second = Convert.ToInt32(Console.ReadLine());
			Console.Write("Choose an Operation\nA\tfor\tAddition\nB\tfor\tSubtraction\nC\tfor\tDivision\nD\tfor\tMultiplication\nChoice: ");
			operation = Console.ReadLine();
			switch(operation)
			{
				case "A":	Add add = new Add();
							add.firstnum = first;
							add.secondnum = second;
							Console.WriteLine("Result: " + add.result());
							break;

				case "B":	Subtract sub = new Subtract();
							sub.firstnum = first;
							sub.secondnum = second;
							Console.WriteLine("Result: " + sub.result());
							break;
				case "C":
					Divide div = new Divide();
					div.firstnum = first;
					div.secondnum = second;
					Console.WriteLine("Result: " + div.result());
					break;
				case "D":
					Multiply multiply = new Multiply();
					multiply.firstnum = first;
					multiply.secondnum = second;
					Console.WriteLine("Result: " + multiply.result());
					break;
			}

			Console.ReadKey();

		}
	}
}
