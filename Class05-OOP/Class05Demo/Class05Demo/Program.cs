using Class05Demo.Classes;
using System;

namespace Class05Demo
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			//Human person = new Human("Allisa");
			//Human person2 = new Human();

			// Human is the base class for these 3 classes
			// Tre and Jimmy are derived classes
			// John is a derived class from Jimmy
			// Thus, Jimmy is both a base class and a derived class
			Jimmy jimmy = new Jimmy();
			Tre tre = new Tre();
			John john = new John();

			// can't do this, because Robot is abstract
			// Robot neth = new Robot();

			Jeff jeff = new Jeff("Jeff", 34);
			string answer = jeff.TakeOverTheWorld();
			Console.WriteLine(answer);

			// these four can be in the same array because they
			// are all derived from the Creature class
			Creatures[] myHumans = { jimmy, john, tre, jeff };
			for (int i = 0; i < myHumans.Length; i++)
			{
				if (myHumans[i] is Human)
				{
					// this outputs only 3 humans 
					// because jeff is a robot
					Console.WriteLine($"{myHumans[i].Name} is human.");
				}
			}
		}
	}
}
