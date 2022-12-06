using System;

namespace Chessboard.Models
{
  public class Board
  {
    //8x8 grid
    public int Size { get; set; }
    //2d array notation
    public Cell [,] boardGrid { get; set; }
    
    public Board (int x)
    {
      Size = x;
      boardGrid = new Cell[Size, Size];
      //fill the 2D array with unique x/y coordinates
      for (int i = 0; i < Size; i++)
      {
        for (int j = 0; j < Size; j++)
        {
          boardGrid[i,j] = new Cell(i,j);
        }
      }
    }
  public void NextLegalMoves(Cell currentCell, string piece)
  {
    // clear all previous moves
    for (int i = 0; i < Size; i++)
      {
        for (int j = 0; j < Size; j++)
        {
          boardGrid[i,j].LegalMove = false;
          boardGrid[i,j].Occupied = false;
        }
      }
    // find all legal moves & mark legal
    
    switch(piece)
    {
      case "Knight":
        boardGrid[currentCell.RowNumber + 2, currentCell.ColNumber + 1].LegalMove = true;
        boardGrid[currentCell.RowNumber + 2, currentCell.ColNumber - 1].LegalMove = true;
        boardGrid[currentCell.RowNumber - 2, currentCell.ColNumber + 1].LegalMove = true;
        boardGrid[currentCell.RowNumber - 2, currentCell.ColNumber - 1].LegalMove = true;
        boardGrid[currentCell.RowNumber + 1, currentCell.ColNumber + 2].LegalMove = true;
        boardGrid[currentCell.RowNumber + 1, currentCell.ColNumber - 2].LegalMove = true;
        boardGrid[currentCell.RowNumber - 1, currentCell.ColNumber + 2].LegalMove = true;
        boardGrid[currentCell.RowNumber - 1, currentCell.ColNumber - 2].LegalMove = true;
        break;

      case "King":
        boardGrid[currentCell.RowNumber - 1, currentCell.ColNumber - 1].LegalMove = true;
        boardGrid[currentCell.RowNumber - 1, currentCell.ColNumber + 1].LegalMove = true;
        boardGrid[currentCell.RowNumber + 1, currentCell.ColNumber - 1].LegalMove = true;
        boardGrid[currentCell.RowNumber + 1, currentCell.ColNumber + 1].LegalMove = true;
        boardGrid[currentCell.RowNumber + 0, currentCell.ColNumber - 1].LegalMove = true;
        boardGrid[currentCell.RowNumber - 0, currentCell.ColNumber + 1].LegalMove = true;
        boardGrid[currentCell.RowNumber - 1, currentCell.ColNumber + 0].LegalMove = true;
        boardGrid[currentCell.RowNumber + 1, currentCell.ColNumber + 0].LegalMove = true;
        break;

      case "Queen":
        //copy loops from Rook & Bishop
        break;

      case "Rook":
        //make a loop that flags current row and col
        break;
      
      case "Bishop":
        //make a loop that flags a slope of 1
        break;

      case "Pawn":
        boardGrid[currentCell.RowNumber + 1, currentCell.ColNumber].LegalMove = true;
        break;
    }
  }
  }
}