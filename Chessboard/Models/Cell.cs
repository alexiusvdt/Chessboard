using System;

namespace Chessboard.Models
{
  public class Cell
  {
    public int RowNumber { get; set; }
    public int ColNumber { get; set; }
    public bool Occupied { get; set; }
    public bool LegalMove { get; set; }
  
    public Cell(int x, int y)
    {
      RowNumber = x;
      ColNumber = y;
    }
  }
}