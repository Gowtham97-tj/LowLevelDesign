using System;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TicTacToeGame ticTacToeGame = new TicTacToeGame(3);
            ticTacToeGame.initializeGame();
            Console.WriteLine("the winner is " + ticTacToeGame.startGame());
        }
    }
}
