using System;
using System.Collections.Generic;
using System.Text;

namespace Class05Demo.Classes
{
	// ACCESS MODIFIERS and ENCAPSULATION:
	// - public = anyone can access it
	// - private = only this class can access it
	// - protected = only this class, plus any derived classes,
	// can access it
	// - internal = only this assembly can access it
	// - protected internal = this project/assembly and any derived 
	// children of this project/assembly
	// **private is the default**

	abstract class Neth : Robot
	{
		// the "= 10" at the end sets the default value
		public int SaltinessRating { get; set; } = 10;

		// this is a virtual property from Robot 
		// that Neth is overriding
		public override int NumberOfArms { get; set; } = 8;

		// this constructor is required because the base class
		// requires a name in its constructor
		public Neth(string name, int number) : base(name)
		{
		}

		// METHODS
		// "override" tells us that this method is overriding a 
		// virtual method in the base class
		// "sealed" means that classes derived from Neth (this class)
		// will not be able to override the method
		public override sealed string TakeOverTheWorld()
		{
			return base.TakeOverTheWorld() + " Free tuna juice for kitties!";
		}

		// no method body, because the derived classes MUST 
		// override this method
		public abstract string[] EatTheRich();



	}
}
