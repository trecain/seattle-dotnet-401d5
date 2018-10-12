using System;
using System.Collections.Generic;
using System.Text;

namespace Class04Demo.Classes
{
	class Library
	{

		public Book[] Books { get; set; }

		public void CheckOut()
		{
			Console.WriteLine("I'm Checked out!");
		}
	}
}
