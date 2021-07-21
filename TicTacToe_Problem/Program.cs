using System;

namespace TicTacToe_Problem
{
    class Program
    {
        static void ticTacToeBoard()
        {
            int boardSize = 10;
            char[] board = new char[boardSize];
            for (int i=0; i<boardSize; i++)
            {
                board[i] = ' ';
            }

            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[1], board[2], board[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[4], board[5], board[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[7], board[8], board[9]);
            Console.WriteLine("     |     |      ");
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
            Console.WriteLine("userLetter is : " + userLetter + " computerLatter is : " + computerLatter);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to tic tac toe problem");
            ticTacToeBoard();
            chooseLetter();
        }
    }
}
