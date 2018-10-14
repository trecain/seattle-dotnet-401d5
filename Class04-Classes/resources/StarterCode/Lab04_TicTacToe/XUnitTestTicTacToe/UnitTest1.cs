using System;
using Xunit;
using static Lab04_TicTacToe.Program;
using Lab04_TicTacToe.Classes;

namespace XUnitTestTicTacToe
{
    public class UnitTest1
    {
        //Given a game board, test for winners.
        [Fact]
        public void TestGameForWinners()
        {
            Player playerOneTest = new Player("Jimmy", "X", true);
            Player playerTwoTest = new Player("Jeff", "O", false);
            Game game = new Game(playerOneTest, playerTwoTest);
            game.Board.GameBoard[0, 0] = "O";
            game.Board.GameBoard[1, 0] = "O";
            game.Board.GameBoard[2, 0] = "O";
            Assert.True(game.CheckForWinner(game.Board));
        }
    }
}
