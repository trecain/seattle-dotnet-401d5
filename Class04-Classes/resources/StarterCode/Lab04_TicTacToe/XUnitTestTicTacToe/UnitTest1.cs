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

        
        //Switch in players before turns
        [Fact]
        public void CanSwitchPlayers()
        {
            Player playerOneTest = new Player("Jimmy", "X", true);
            Player playerTwoTest = new Player("Jeff", "O", false);
            Game game = new Game(playerOneTest, playerTwoTest);
            game.SwitchPlayer();
            Assert.True(game.PlayerTwo.IsTurn);
            Assert.False(game.PlayerOne.IsTurn);
        }

        //Position player chooses correlates to the correct index of the array
        [Fact]
        public void CorrelatesToTheCorrectIndex()
        {
            Player playerOneTest = new Player("Jimmy", "X", true);
            Player playerTwoTest = new Player("Jeff", "O", false);
            Game game = new Game(playerOneTest, playerTwoTest);
            Position positionOne = Player.PositionForNumber(3);
            Position positionTwo = Player.PositionForNumber(8);
            game.Board.GameBoard[positionOne.Row, positionOne.Column] = playerOneTest.Marker;
            game.Board.GameBoard[positionTwo.Row, positionTwo.Column] = playerTwoTest.Marker;
            Assert.Equal("X", game.Board.GameBoard[0, 2]);
            Assert.Equal("O", game.Board.GameBoard[2, 1]);        
        }

        //Should construct a new board
        [Fact]
        public void CanGenerateANewBoard()
        {
            Board board = new Board();
            Assert.Equal("2", board.GameBoard[0, 1]);
            Assert.Equal("3", board.GameBoard[0, 2]);
            Assert.Equal("8", board.GameBoard[2, 1]);
        }
    }
}
