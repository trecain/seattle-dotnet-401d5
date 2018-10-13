using System;
using System.Collections.Generic;
using System.Text;

namespace Class05Demo.Classes
{
	// this is our "incomplete" base class
	// it is abstract, so it cannot instantiate objects
	abstract class Robot : Creatures
	{
		// PROPERTIES

		// this abstract property MUST be overridden
		public abstract bool HasEyeLazers { get; set; }
		// this virtual property MAY by overridden
		public virtual int NumberOfArms { get; set; } = 4;
		public string Name { get; set; }

		// constructor
		public Robot(string name)
		{
			Name = name;
		}

		// methods
		// "virtual" means that this method CAN BE overridden in a 
		// derived class.  It does not HAVE to be overridden
		public virtual string TakeOverTheWorld()
		{
			return $"{Name} has taken over the world.  It is your leader.";
		}

		// "abstract" means that this method MUST BE overridden in
		// the first concrete derived class, UNLESS a class 
		// further up the hierarchy has already overridden it
		//public abstract bool EatsCookies();


	}
}
