using Lab04_TicTacToe.Classes;
using System;

namespace Lab04_TicTacToe
{
	class Program
	{
		static void Main(string[] args)
		{
            //Instantiate the Board class
            Board board = new Board();
            //Run theh logic of the game.
            PlayGame();
		}

		static void PlayGame()
		{
            // DONE: Instantiate your players
            // Create the Game
            // Play the Game
            // Output the winner
            Console.Write("Enter your name challenger one: ");
            string playerOneName = Console.ReadLine();
            Player playerOne = new Player(playerOneName, "X", true);
            Console.Write("Enter your name challenger two: ");
            string playerTwoName = Console.ReadLine();
            Player playerTwo = new Player(playerTwoName, "O", false);
            Game game = new Game(playerOne, playerTwo);
            game.Play();
		}
	}
}
