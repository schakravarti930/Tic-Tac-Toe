using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class TicTacToeGame
    {
        public char[] Board;
        public void CreateBoard()
        {
            Board = new char[10];
            for(int i = 1; i < Board.Length; i++)
            {
                Board[i] = ' ';
            }
        }
        public char ChooseLetter()
        {
            while (true)
            {
                Console.WriteLine("Choose a Letter among 'X' or 'O' ");
                char userLetter = Convert.ToChar(Console.ReadLine());
                if (userLetter == 'X' || userLetter == 'O' || userLetter == 'x' || userLetter == 'o')
                {
                    return userLetter;
                }
                else
                {
                    Console.WriteLine("Invalid Input. Try Again.");
                }
            }
        }
    }
}
