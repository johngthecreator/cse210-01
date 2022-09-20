using System;
using System.Collections.Generic;

namespace tic_tac
{
    class Program
    {
        static int currPlayer = 0;
        static bool hasWinner = false;
        static int roundCount = 0;
        static Dictionary<int, string> Pieces = new Dictionary<int, string>(){
        {1,"1"},
        {2,"2"},
        {3,"3"},
        {4,"4"},
        {5,"5"},
        {6,"6"},
        {7,"7"},
        {8,"8"},
        {9,"9"},
    };
        static void Main(string[] args)
        {
            while (hasWinner != true && roundCount < 9)
            {
                PrintBoard();
                PlayerTurn();
                WinLogic();
                roundCount += 1;
            }
            if (roundCount == 9 && hasWinner != true){
                Console.WriteLine("Game Over, it was a Tie!");
            }
        }

        public static void PrintBoard()
        {
            Console.WriteLine(Pieces[1] + "|" + Pieces[2] + "|" + Pieces[3]);
            Console.WriteLine("-+-+-");
            Console.WriteLine(Pieces[4] + "|" + Pieces[5] + "|" + Pieces[6]);
            Console.WriteLine("-+-+-");
            Console.WriteLine(Pieces[7] + "|" + Pieces[8] + "|" + Pieces[9]);
        }
        public static void WinLogic()
        {
            if (Pieces[1] == Pieces[2] && Pieces[1] == Pieces[3])
            {
                hasWinner = true;
                Console.WriteLine(currPlayer == 1 ? "Player X won the game!": "Player O won the game!");
            }
            else if (Pieces[4] == Pieces[5] && Pieces[4] == Pieces[6])
            {
                hasWinner = true;
                Console.WriteLine(currPlayer == 1 ? "Player X won the game!": "Player O won the game!");
            }
            else if (Pieces[7] == Pieces[8] && Pieces[7] == Pieces[9])
            {
                hasWinner = true;
                Console.WriteLine(currPlayer == 1 ? "Player X won the game!": "Player O won the game!");
            }
            else if (Pieces[1] == Pieces[4] && Pieces[1] == Pieces[7])
            {
                hasWinner = true;
                Console.WriteLine(currPlayer == 1 ? "Player X won the game!": "Player O won the game!");
            }
            else if (Pieces[2] == Pieces[5] && Pieces[2] == Pieces[8])
            {
                hasWinner = true;
                Console.WriteLine(currPlayer == 1 ? "Player X won the game!": "Player O won the game!");
            }
            else if (Pieces[3] == Pieces[6] && Pieces[3] == Pieces[9])
            {
                hasWinner = true;
                Console.WriteLine(currPlayer == 1 ? "Player X won the game!": "Player O won the game!");
            }
            else if (Pieces[1] == Pieces[5] && Pieces[1] == Pieces[9])
            {
                hasWinner = true;
                Console.WriteLine(currPlayer == 1 ? "Player X won the game!": "Player O won the game!");
            }
            else if (Pieces[3] == Pieces[5] && Pieces[3] == Pieces[7])
            {
                hasWinner = true;
                Console.WriteLine(currPlayer == 1 ? "Player X won the game!": "Player O won the game!");
            }
        }

        public static void PlayerTurn()
        {
            if (currPlayer == 0)
            {
                Console.WriteLine("Player X:");
                string boardNum = Console.ReadLine();
                if (boardNum.Length > 0)
                {
                    int boardLoc = int.Parse(boardNum);
                    if (Pieces[boardLoc] != "O")
                    {
                        Pieces[boardLoc] = "X";
                        currPlayer = 1;
                    }
                    else
                    {
                        Console.WriteLine("You can't do that");
                    }
                }
            }
            else
            {
                Console.WriteLine("Player O:");
                string boardNum = Console.ReadLine();
                if (boardNum.Length > 0)
                {
                    int boardLoc = int.Parse(boardNum);
                    if (Pieces[boardLoc] != "X")
                    {
                        Pieces[boardLoc] = "O";
                        currPlayer = 0;
                    }
                    else
                        Console.WriteLine("You can't do that");
                }
            }
        }
    }
}
