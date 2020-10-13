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
        public void ShowBoard()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", Board[1], Board[2], Board[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", Board[4], Board[5], Board[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", Board[7], Board[8], Board[9]);
            Console.WriteLine("     |     |      ");
        }
        public void MakeMove(char userLetter)
        {
            int index;
            do
            {
                Console.WriteLine($"Enter the Index You want to Place {userLetter}");
                index = Convert.ToInt32(Console.ReadLine());
                if (index > this.Board.Length || this.Board[index] != ' ')
                {
                    Console.WriteLine("Enter Again. Cell Not Free or Out of Index");
                }
            } while (index > this.Board.Length || this.Board[index] != ' ');
            this.Board[index] = userLetter;
        }
    }
}
