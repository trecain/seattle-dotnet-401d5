using System;
using System.IO;
using System.Text;

namespace Class03Demo
{
	class Program
	{
		static void Main(string[] args)
		{
			string path = "../../../myfile.txt";
			Console.WriteLine("Hello World!");
			//CreateFile(path);
			//ReadFile(path);
			//AppendToFile(path);

			DeleteLineFromFile(path);
		}

		static void CreateFile(string path)
		{
			try
			{
				using (StreamWriter sw = new StreamWriter(path))
				{
					try
					{
						sw.Write("Hello Tre!");
					}
					catch (Exception)
					{

						throw;
					}
					finally
					{
						sw.Close();
					}


				}
			}
			catch (Exception)
			{

				throw;
			}
			finally
			{
				// close the file
			}

			// Second way to create a file
			try
			{
				using (FileStream fs = File.Create(path))
				{
					Byte[] myWords = new UTF8Encoding(true).GetBytes("Hello Class!");
					fs.Write(myWords, 0, myWords.Length);
				}
			}
			catch (Exception)
			{

				throw;
			}
		}

		static string[] ReadFile(string path)
		{
			//try
			//{
			//	using (StreamReader sr = File.OpenText(path))
			//	{
			//		string s = "";

			//		while ((s = sr.ReadLine()) != null)
			//		{
			//			Console.WriteLine(s);
			//		}

			//	}
			//}
			//catch (Exception)
			//{

			//	throw;
			//}

			try
			{
				string[] myWords = File.ReadAllLines(path);
				return myWords;
			}
			catch (Exception)
			{

				throw;
			}
		}

		static void AppendToFile(string path)
		{
			try
			{
				using (StreamWriter sw = File.AppendText(path))
				{
					for (int i = 1; i < 6; i++)
					{
						sw.WriteLine(i);
						
					}
					
				}
			}
			catch (Exception)
			{

				throw;
			}
			

		}

		static void DeleteLineFromFile(string path, string lineToRemove)
		{
			// needs some error handling
			string[] currentWords = ReadFile(path);
			string[] newWords = new string[currentWords.Length - 1];
			for (int i = 0; i < currentWords.Length; i++)
			{
				if (lineToRemove == currentWords[i])
				{
					// remove from array
					// continue on your own! 
				}
			}
			// now write the file back out
		}

		static void DeleteAFile(string path)
		{
			File.Delete(path);
		}

	}
}
