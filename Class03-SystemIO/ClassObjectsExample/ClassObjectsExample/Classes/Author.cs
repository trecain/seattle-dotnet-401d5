using System;
using System.Collections.Generic;
using System.Text;

namespace ClassObjectsExample.Classes
{
	class Author
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }


		public Author(string firstname, string lastname)
		{
			FirstName = firstname;
			LastName = lastname;
		}

		public bool ScheduleSigning()
		{
			return true;
		}

		
	}
}
