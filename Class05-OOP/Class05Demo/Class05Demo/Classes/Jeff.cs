using System;
using System.Collections.Generic;
using System.Text;

namespace Class05Demo.Classes
{
	// this class is not abstract, therefore it is 
	// a concrete class; it can be instantiated
	class Jeff : Neth
	{
		// this constructor is required because the base class
		// requires a name in its constructor
		// it's constructors all the way down
		public Jeff(string name, int age) : base(name, age)
		{
		}

		public override bool HasEyeLazers { get; set; } = true;

		// because TakeOverTheWorld is sealed in the Neth class,
		// if Jeff wants to rule he has to use a different method
		public string ConquerTheWorld()
		{
			return "Mine now";
		}

		public override string[] EatTheRich()
		{
			throw new NotImplementedException();
		}

		// can't do this, because Jeff is a concrete class and EatNeth
		// is abstract
		// public abstract void EatNeth();
		
	}
}
