using System;
using System.Collections.Generic;
using System.Text;

namespace ClassObjectsExample.Classes
{
	class Customer
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public Book[] CurrentBooks { get; set; }

		public Customer(string firstname, string lastname)
		{
			FirstName = firstname;
			LastName = lastname;
			CurrentBooks = new Book[1];
		}

		public void ShowBooks()
		{
			foreach (Book item in CurrentBooks)
			{
				if(item != null)
				{
					Console.WriteLine(item.Title);

				}
			}
		}
	}
}
