using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToeGame game = new TicTacToeGame();
            game.CreateBoard();
            game.ShowBoard();
            char userLetter = game.ChooseLetter();
            char computerLetter;
            if (userLetter == 'X' || userLetter == 'x')
                computerLetter = 'O';
            else
                computerLetter = 'X';
            Console.WriteLine(userLetter +" " + computerLetter);
        }
    }
}
