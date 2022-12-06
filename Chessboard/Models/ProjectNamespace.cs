using System;

namespace Chessboard.Models
{
  public class Cell
  {
    public int RowNumber { get; set; }
    public int ColNumber { get; set; }
    public bool Occupied { get; set; }
    public bool LegalMove { get; set; }
  }
}