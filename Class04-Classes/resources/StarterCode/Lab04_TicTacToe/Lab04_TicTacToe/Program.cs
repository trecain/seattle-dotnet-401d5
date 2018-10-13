using Lab04_TicTacToe.Classes;
using System;

namespace Lab04_TicTacToe
{
	class Program
	{
		static void Main(string[] args)
		{
            Board board = new Board();
            PlayGame();
		}

		static void PlayGame()
		{
            // TODO: Instantiate your players
            // Create the Game
            // Play the Game
            // Output the winner
            Console.Write("Player one, enter your name: ");
            string playerOneName = Console.ReadLine();
            Player playerOne = new Player(playerOneName, "X", true);
            Console.Write("Player two, enter your name: ");
            string playerTwoName = Console.ReadLine();
            Player playerTwo = new Player(playerTwoName, "O", false);
            Game game = new Game(playerOne, playerTwo);
            game.Play();
		}
	}
}
