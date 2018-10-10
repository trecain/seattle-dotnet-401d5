using System;

namespace Class02Demo
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}

		public static string Convert(int num)
		{ 
			if (num % 15 == 0)
			{
				return "FizzBuzz";
			} else if (num % 3 == 0)
			{
				return "Fizz";
			} else if (num % 5 == 0)
			{
				return "Buzz";
			}
			return num.ToString();
		}
	}
}
