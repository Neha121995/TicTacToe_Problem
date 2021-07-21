using System;

namespace TicTacToe_Problem
{
    class Program
    {
        static void ticTacToeBoard()
        {
            int boardSize = 10;
            char[] board = new char[boardSize];
            for (int i=1; i<boardSize; i++)
            {
                board[i] = ' ';
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to tic tac toe problem");
            ticTacToeBoard();
        }
    }
}
