using System;
using System.Collections.Generic;
class Program {
    // static string[] pieces = {"hs", "el"};
    // static List<string> boardPieces = new List<string>();
    static int currPlayer = 0;
    static bool hasWinner = false;
    static bool isTie = false;
    static Dictionary<int,string> Pieces = new Dictionary<int,string>(){
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
    static void Main(string[] args){
        while (hasWinner != true){
            PrintBoard();
            PlayerTurn();
            WinLogic();
            // TieLogic();
        }
    }
    // public static void ReturnPieces(){
    //     boardPieces.AddRange(pieces);
    //     Console.WriteLine(boardPieces.Count);
    //     for (int p = 0; p < boardPieces.Count; p++){
    //         Console.WriteLine(boardPieces[p]);
    //     };
    // }
    
    // public static void TieLogic(){
    //     int numSpotsOpen = 0;
    //     foreach(KeyValuePair<int, string> e in Pieces){
    //         if (e.Value == "O") {
    //         }else if (e.Value == "X"){
    //         }else{
    //             numSpotsOpen += 1;
    //         }
    //     }
    //     if (numSpotsOpen == 0){
    //         isTie = true;
    //     }
    // }

    public static void PrintBoard(){
        Console.WriteLine(Pieces[1] + "|" + Pieces[2] + "|" + Pieces[3] );
        Console.WriteLine("-+-+-");
        Console.WriteLine(Pieces[4] + "|" + Pieces[5] + "|" + Pieces[6] );
        Console.WriteLine("-+-+-");
        Console.WriteLine(Pieces[7] + "|" + Pieces[8] + "|" + Pieces[9] );
    }
    public static void WinLogic(){
        if (Pieces[1] == Pieces[2] && Pieces[1] == Pieces[3]){
            hasWinner = true;
            Console.WriteLine(currPlayer + "won the game!");
        } else if (Pieces[4] == Pieces[5] && Pieces[4] == Pieces[6]) {
            hasWinner = true;
            Console.WriteLine(currPlayer + "won the game!");
        } else if (Pieces[7] == Pieces[8] && Pieces[7] == Pieces[9]){
            hasWinner = true;
            Console.WriteLine(currPlayer + "won the game!");
        } else if (Pieces[1] == Pieces[4] && Pieces[1] == Pieces[7]){
            hasWinner = true;
            Console.WriteLine(currPlayer + "won the game!");
        } else if (Pieces[2] == Pieces[5] && Pieces[2] == Pieces[8]) {
            hasWinner = true;
            Console.WriteLine(currPlayer + "won the game!");
        } else if (Pieces[3] == Pieces[6] && Pieces[3] == Pieces[9]){
            hasWinner = true;
            Console.WriteLine(currPlayer + "won the game!");
        } else if (Pieces[1] == Pieces[5] && Pieces[1] == Pieces[9]){
            hasWinner = true;
            Console.WriteLine(currPlayer + "won the game!");
        }else if (Pieces[3] == Pieces[5] && Pieces[3] == Pieces[7]){
            hasWinner = true;
            Console.WriteLine(currPlayer + "won the game!");
        }
    } 

    public static void PlayerTurn(){
        if(currPlayer == 0){
            Console.WriteLine("Player X:");
            string boardNum = Console.ReadLine();
            if (boardNum.Length > 0){
                int boardLoc = Int32.Parse(boardNum);
                if (Pieces[boardLoc] != "O") {
                    Pieces[boardLoc] = "X";
                    currPlayer = 1;
                } else {
                    Console.WriteLine("You can't do that");
                }
            }
        } else {
            Console.WriteLine("Player O:");
            string boardNum = Console.ReadLine();
            if (boardNum.Length > 0){
                int boardLoc = Int32.Parse(boardNum);
                if (Pieces[boardLoc] != "X") {
                    Pieces[boardLoc] = "O";
                    currPlayer = 0;
                } else 
                    Console.WriteLine("You can't do that");
                }
            }
        }
    }

    // public static void ReturnForEach(){
    //     boardPieces.AddRange(pieces);
    //     foreach(string p in boardPieces){
    //         Console.WriteLine(p);
    //     };
    // }

    // public static void ReturnName(){
    //     Console.WriteLine("Enter First Name:");
    //     string firstName = Console.ReadLine();
    //     Console.WriteLine("Enter Last Name:");
    //     string lastName = Console.ReadLine();
    //     int firstCount = firstName.Length;
    //     int lastCount = lastName.Length;
    //     if (firstCount > 0 && lastCount > 0){
    //         Console.WriteLine(firstName + " " + lastName);
    //     }else if (firstCount <= 0){
    //         Console.WriteLine("You didn't put a first name");
    //     }else if (lastCount <= 0) {
    //         Console.WriteLine("You didn't put a last name");
    //     }
    // }
}
