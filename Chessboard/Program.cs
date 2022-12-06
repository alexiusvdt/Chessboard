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
      Cell currentCell = setCurrentCell();
      currentCell.Occupied = true;
      // calculate all legal moves
      myBoard.NextLegalMoves(currentCell, "Knight");
      // print the chess board. use X for occupied square, + for legal move, . for empty cell
      printBoard(myBoard);
      // wait for another entry
      Console.ReadLine();

    }

    private static Cell setCurrentCell()
    {
      // x and y coords from user
      // assumes perfect inputs, add error checking for user validation
      Console.WriteLine("Enter the current row number");
      int currentRow = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter the current column number");
      int currentCol = int.Parse(Console.ReadLine());
      //return location on grid

      myBoard.boardGrid[currentRow, currentCol].Occupied = true;
      return myBoard.boardGrid[currentRow, currentCol];
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