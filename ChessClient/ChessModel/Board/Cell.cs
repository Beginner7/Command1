using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChessModel.Figures;

namespace ChessModel.Board
{
    public class Cell
    {
        public Cell(Figure figure)
        {
            Figure = figure;
        }

        public Cell()
        {
            // TODO: Complete member initialization
        }
        public Figure Figure { get; set; }
    }

    public class CellPosition
    {
        public CellPosition(string position)
        {
            X = position[0] - 'a';
            Y = (position[1] - '1');
            if (X < 0 || X > 7)
                throw new ArgumentException("X вышел за пределы доски");
            if (Y < 0 || Y > 7)
                throw new ArgumentException("Y вышел за пределы доски");
        }

        public int X { get; set; }
        public int Y { get; set; }
    }

    public class CellMove
    {
        public CellMove(string move)
        {
            string[] positons = move.Split('-');
            Begin = new CellPosition(positons[0]);
            End = new CellPosition(positons[1]);
        }

        public CellPosition Begin { get; private set; }
        public CellPosition End { get; private set; }
    }

}
