﻿using System;
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
            for(int i = 0; i < Board.Length; i++)
            {
                Board[i] = 'a';
            }
        }
    }
}
