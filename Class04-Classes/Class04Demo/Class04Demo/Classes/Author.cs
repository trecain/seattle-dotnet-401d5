using System;
using System.Collections.Generic;
using System.Text;

namespace Class04Demo.Classes
{
	class Author
	{
		// The New Cool THing as of C#6;
		public string FirstName { get; set; }

		//Old way in legacy code
		private int _age;

		public int Age
		{
			get
			{
				return _age;
			}
			set
			{
				_age = value;
			}

		}

		public Author()
		{

		}
	}
}
