using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessModel.Board
{
    public class ChessBoard
    {
        private const int BoardWidth = 8;

        public ChessBoard()
        {

        }

        public bool Move(CellMove move)
        {
            return true;
        }

        public Cell[,] Cells = new Cell[BoardWidth, BoardWidth];
    }
}
