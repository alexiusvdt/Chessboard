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
  }
}