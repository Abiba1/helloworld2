using System;

namespace Lab4._1
{
	class Program
	{
		private static double A, B;

		static void Main(string[] args)
		{
			while (true)
			{
				PrintMenu();
				DoAction(Console.ReadLine());
			}
		}

		static void PrintMenu() =>
			Console.WriteLine("1: Input A\n2: Input B\n3: +\n4: -\n5: *\n6: /");

		static void DoAction(string input)
		{
			switch (input)
			{
				case "1":
					InputA(Console.ReadLine());
					break;
				case "2":
					InputB(Console.ReadLine());
					break;
				case "3":
					Plus(A, B);
					break;
				case "4":
					Minus(A, B);
					break;
				case "5":
					Multiply(A, B);
					break;
				case "6":
					Divide(A, B);
					break;
				default:
					Console.WriteLine("Unrecognized command.");
					break;
			}
		}

		static void InputA(string input)
		{
			try
			{
				A = double.Parse(input);
			}
			catch (Exception)
			{
				Console.WriteLine("Please type in a number.");
			}
		}

		static void InputB(string input)
		{
			try
			{
				B = double.Parse(input);
			}
			catch (Exception)
			{
				Console.WriteLine("Please type in a number.");
			}
		}
		static void Plus(double a, double b) => Console.WriteLine(a + b);

		static void Minus(double a, double b) => Console.WriteLine(a - b);

		static void Multiply(double a, double b) => Console.WriteLine(a * b);

		static void Divide(double a, double b) => Console.WriteLine(a / b);
	}
}