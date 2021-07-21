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
        static void chooseLetter()
        {
            String userLetter = " ";
            String computerLatter = " ";
            while (true)
            {
                Console.WriteLine("Choose the latter X or O");
                userLetter = Console.ReadLine();
                if (userLetter == "X" || userLetter == "x")
                {
                    computerLatter = "O";
                    break;
                }
                else if (userLetter == "O" || userLetter == "o")
                {
                    computerLatter = "X";
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Letter");
                }
            }
            Console.WriteLine("userLetter : " + userLetter + " computerLatter : " + computerLatter);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to tic tac toe problem");
            ticTacToeBoard();
            chooseLetter();
        }
    }
}
