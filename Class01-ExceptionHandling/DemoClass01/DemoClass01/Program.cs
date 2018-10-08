using System;

namespace DemoClass01
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			//try
			//{
			//	MethodA();
			//}
			//catch (Exception e)
			//{
			//	Console.WriteLine(e.Message);
				
			//}

			Console.WriteLine(ThisIsMyMethod());

			
			//TryBlockExample();
		}

		static void TryBlockExample()
		{

			int number = 13, denom = 0, result = 0;

			int[] myNumbers = { 4, 8, 15 };


			// the code in this block could potentially throw an exception
			//try
			//{
			//int myAnswer = number / denom;

			//result = myNumbers[number];

			Console.WriteLine("Please enter your name");
			int answser = Convert.ToInt32(Console.ReadLine());
			//}
			//catch(FormatException e)
			//{
			//	Console.WriteLine("Please don't break my name");
			//}
			//catch (DivideByZeroException e)
			//{
			//	Console.WriteLine("You did something wrong. Don't divide by Zero");
			//	Console.WriteLine($"Your Message is: {e.Message}");
			//}
			//catch (IndexOutOfRangeException e)
			//{
			//	Console.WriteLine("You did something wrong. It's out of range");
			//	Console.WriteLine($"Your Message is: {e.Message}");
			//}
			//catch (Exception e)
			//{
			//	Console.WriteLine("Ooops, it broke!");
			//	Console.WriteLine(e.Message);
			//}
			//finally
			//{
			//	Console.WriteLine("WELCOME TO CLASS!");
			//}
		}

		static void MethodA()
		{
			try
			{
				Console.WriteLine("I am in Method A");
				MethodB();
			}
			catch (Exception)
			{
				Console.WriteLine("Caught in Method A");
				throw;
			}
		}

		static void MethodB()
		{
			try
			{
				Console.WriteLine("I am in Method B");
				MethodC();
			}
			catch (Exception)
			{
				Console.WriteLine("Caught In Method B");
				throw;
			}
		}

		static void MethodC()
		{
			Console.WriteLine("I am in Method C");

			throw (new Exception("This is an Exception in Method C"));
		}


		static int ThisIsMyMethod()
		{
			// Setting number equal to 4. 
			int number = 4;

			int second = 8;

			int answer = number + second;

			return answer;
		}

	}
}
