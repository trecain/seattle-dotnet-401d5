using ClassObjectsExample.Classes;
using System;

namespace ClassObjectsExample
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			BookExample();
		}

		static void BookExample()
		{
			Author author = new Author("JK", "Rowling");
			Book book = new Book("Harry Potter", 327, 1997, author);

			Author author1 = new Author("Dr", "Seuss");
			Book book1 = new Book("Red Fish Blue Fish", 40, 1950, author1);

			Book[] books = { book, book1 };

			Library library = new Library(books);

			Customer customer = new Customer("Amanda", "Iverson");

			library.LendBook(book1, customer);

			Console.WriteLine($"The Current Books {customer.FirstName} owns is:");
			customer.ShowBooks();

			Console.WriteLine($"The Library Books are:");
			library.DisplayAvailableBooks();




		}

	}
}
