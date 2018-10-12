using Class04Demo.Classes;
using System;

namespace Class04Demo
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			AuthorExample();
		}

		static void AuthorExample()
		{
			// Instantiating a new author object.
			Author myAuthor = new Author();

			myAuthor.FirstName = "Amanda";
			myAuthor.Age = 55;

			Author newAuthor = new Author
			{
				FirstName = "Molly",
				Age = 60
			};

			
			string name = myAuthor.FirstName;

			Book book = new Book("Harry Potter", myAuthor);

			Book myBook = book;

			book = null;

			//Console.WriteLine(book.Title);

			//book.Title = "CandyLand";

			Console.WriteLine(myBook.Title);
			//Console.WriteLine(book.Title);

			Book bk = new Book("Alice in Wonderland", newAuthor)
			{
				NumberOfPages = 100
			};




		}

		static void LibraryExample()
		{
			Library library = new Library();

			library.CheckOut();
		}


	}
}
