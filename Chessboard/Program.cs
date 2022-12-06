using System;
using Chessboard.Models;

namespace MyProgram {
  class Program 
  {
    static Board myBoard = new Board(8); 

    static void Main(string[] args)
    {
      
      // show an empty board
      printBoard(myBoard);
      // get user X and Y inputs
      // calculate all legal moves
      // print the chess board. use X for occupied square, + for legal move, . for empty cell
      // wait for another entry
      Console.ReadLine();

    }
    private static void printBoard(Board myBoard)
    {
      //print it!
      //row printer
      for (int i = 0; i < myBoard.Size; i++)
      {
        //col printer
        for (int j = 0; j < myBoard.Size; j++)
        {
          Cell c = myBoard.boardGrid[i,j];
          if (c.Occupied == true)
          {
            Console.Write("X");
          }
          else if (c.LegalMove == true)
          {
            Console.Write("+");
          }
          else 
          {
            Console.Write(".");
          }
        }
        //this should fire every 8 letters to make a new row for the output
        Console.WriteLine();
      }
      Console.WriteLine("=================================================");
    }
  }
}