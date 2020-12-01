using System;

namespace Lab4._1
{
	class Program
	{
		private static double B;

		static void Main(string[] args)
		{
			while (true)
			{
				PrintMenu();
				DoAction(Console.ReadLine());
			}
		}

		static void PrintMenu() =>
			Console.WriteLine("1: Input A\n2: Input B\n3: +\n4: -\n 5: *\n6: /");

		static void DoAction(string input)
		{
			switch (input)
			{
				case "1":
				case "2":
					InputB(Console.ReadLine());
					break;
				case "3":
				case "4":
				case "5":
				case "6":
				default:
					Console.WriteLine("Unrecognized command.");
					break;
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
	}
}
