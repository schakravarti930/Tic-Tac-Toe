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
            string FirstMovePlayer = game.Toss();
            Console.WriteLine($"{FirstMovePlayer} moves First");
            if (FirstMovePlayer.Equals("USER"))
            {
                game.MakeMove(userLetter);
                game.ShowBoard();
            }
            else
            {
                game.MakeMove(computerLetter);
                game.ShowBoard();
            }
           
        }
    }
}
