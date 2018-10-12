using System;
using System.Collections.Generic;
using System.Text;

namespace ClassObjectsExample.Classes
{
	class Book
	{
		public string Title { get; set; }
		public int NumberOfPages { get; set; }
		public int Year { get; set; }
		public Author Author { get; set; }

		public Book(string title, int numberOfPages, int year, Author author)
		{
			Title = title;
			NumberOfPages = numberOfPages;
			Year = year;
			Author = author; 
		}

	}
}
