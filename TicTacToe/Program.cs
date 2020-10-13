using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToeGame.CreateBoard();
            Console.WriteLine(TicTacToeGame.Board);
        }
    }
}
