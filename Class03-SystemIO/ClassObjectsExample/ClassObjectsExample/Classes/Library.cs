using System;

namespace ClassObjectsExample.Classes
{
	class Library
	{
		public Book[] Books { get; set; }

		public Library(Book[] books)
		{
			Books = books;
		}

		public void DisplayAvailableBooks()
		{
			Console.WriteLine();
			Console.WriteLine("Available Books");

			foreach (Book book in Books)
			{
				Console.WriteLine(book.Title);
			}
		}

		public void LendBook(Book book, Customer customer)
		{
			bool isAvailable = false;
			int indexOfBook = -1;
			Book[] newCurrent = new Book[Books.Length - 1];

			// Check if the book is available
			for (int i = 0; i < Books.Length; i++)
			{
				if (Books[i] == book)
				{
					Console.WriteLine("Book is available");
					indexOfBook = i;
					isAvailable = true;
				}
			}


			if (isAvailable)
			{

				Book[] newBooks = new Book[customer.CurrentBooks.Length + 1];


				for (int i = 0; i < customer.CurrentBooks.Length; i++)
				{
					newBooks[i] = customer.CurrentBooks[i];
				}

				newBooks[customer.CurrentBooks.Length - 1] = book;


				customer.CurrentBooks = newBooks;

				// Remove the book from the Library

				// create a new array
				// find the book in the current list
				// only insert books not equal to that index in the list. 

				int counter = 0;

				for (int i = 0; i < Books.Length; i++)
				{
					if (i != indexOfBook)
					{
						newCurrent[counter] = Books[i];
					}
				}

			}

			Books = newCurrent;

		}

		public void ReturnBook(Book book, Customer customer)
		{
			bool hasBook = false;
			int indexOfBook = -1;
			Book[] newCustomerBooks = new Book[customer.CurrentBooks.Length - 1];


			//make sure the customer has the book in their list
			for (int i = 0; i < customer.CurrentBooks.Length; i++)
			{
				if (customer.CurrentBooks[i] == book)
				{
					Console.WriteLine("Customer has book");
					indexOfBook = i;
					hasBook = true;
				}
			}

			int counter = 0;

			// remove book from customer's list
			if (hasBook)
			{
				for (int i = 0; i < customer.CurrentBooks.Length; i++)
				{
					if (i == indexOfBook)
					{
						newCustomerBooks[counter] = customer.CurrentBooks[i];
					}
				}
			}

			customer.CurrentBooks = newCustomerBooks;


			// add book back to library list

			Book[] newBooks = new Book[Books.Length + 1];
			Array.Copy(Books, newBooks, Books.Length + 1);
			customer.CurrentBooks[customer.CurrentBooks.Length - 1] = book;
			Books[Books.Length - 1] = book;
		}

		public void ShowAvailableBooks()
		{
			foreach (Book book in Books)
			{
				Console.WriteLine(book.Title);
			}
		}

	}
}
