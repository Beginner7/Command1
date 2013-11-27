using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChessModel.Figures;

namespace ChessModel.Board
{
    public class ChessBoard
    {
        private const int BoardWidth = 8;

        public ChessBoard()
        {
            Cells = new Cell[BoardWidth, BoardWidth];

            for (int i = 0; i < BoardWidth; i++)
            {
                Cells[i, 1] = new Cell(new Pawn(Figure.FigureColor.White));
                Cells[i, 6] = new Cell(new Pawn(Figure.FigureColor.Black));
            }

            Cells[0, 0] = new Cell(new Castle(Figure.FigureColor.White));
            Cells[7, 0] = new Cell(new Castle(Figure.FigureColor.White));
            Cells[0, 7] = new Cell(new Castle(Figure.FigureColor.Black));
            Cells[7, 7] = new Cell(new Castle(Figure.FigureColor.Black));

            Cells[1, 0] = new Cell(new Horse(Figure.FigureColor.White));
            Cells[6, 0] = new Cell(new Horse(Figure.FigureColor.White));
            Cells[1, 7] = new Cell(new Horse(Figure.FigureColor.Black));
            Cells[6, 7] = new Cell(new Horse(Figure.FigureColor.Black));

            Cells[2, 0] = new Cell(new Officer(Figure.FigureColor.White));
            Cells[5, 0] = new Cell(new Officer(Figure.FigureColor.White));
            Cells[2, 7] = new Cell(new Officer(Figure.FigureColor.Black));
            Cells[5, 7] = new Cell(new Officer(Figure.FigureColor.Black));

            Cells[3, 0] = new Cell(new Queen(Figure.FigureColor.White));
            Cells[4, 0] = new Cell(new King(Figure.FigureColor.White));
            Cells[4, 7] = new Cell(new King(Figure.FigureColor.Black));
            Cells[3, 7] = new Cell(new Queen(Figure.FigureColor.Black));

        }

        public Cell GetCell(CellPosition position)
        {
            return Cells[position.X, position.Y];
        }

        public bool Move(CellMove move)
        {
            return true;
        }

        public Cell[,] Cells { get; private set; }
    }
}
