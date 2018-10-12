using System;
using System.Collections.Generic;
using System.Text;

namespace Class04Demo.Classes
{
	class Book
	{
		public string Title { get; set; }
		public int NumberOfPages { get; set; }
		public Author Author { get; set; }

		public Book(string title , Author author)
		{
			Title = title;
			Author = author;
		}

	}
}
