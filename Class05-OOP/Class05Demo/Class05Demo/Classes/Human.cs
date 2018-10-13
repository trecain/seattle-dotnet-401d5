namespace Class05Demo.Classes
{
	class Human : Creatures
	{
		public string Name { get; set; }
		public bool EatsCake { get; set; }
		public int Age { get; set; }

		// setting a default in the constructor is possible, 
		// but it's bad practice; it defeats the purpose of 
		// having parameters in a constructor in the first place
		//public Human(string name, int Age = 80)
		//{
		//	Name = name;
		//}

		//public Human()
		//{

		//}

		public bool EatFood()
		{
			bool myCat = true;
			EatsCake = true;
			return true;
		}

		public bool EatFood(string food)
		{
			return true;
		}

		public bool EatFood(string candy, string dessert = "Pie")
		{
			return true;


		}

		public bool GoToSleep()
		{
			return true;
		}
		
	}
}
