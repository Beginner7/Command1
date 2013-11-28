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



            for (int i = 0; i <BoardWidth; i++)
            {
                for (int j = 0; j < BoardWidth; j++)
                {
                    Cells[i,j]=new Cell();
                }
            }
            
            for (int i = 0; i < BoardWidth; i++)
            {
                Cells[i, 1].Figure = new Pawn(Figure.FigureColor.White);
                Cells[i, 6].Figure = new Pawn(Figure.FigureColor.Black);
            }

            Cells[0, 0].Figure = new Castle(Figure.FigureColor.White);
            Cells[7, 0].Figure = new Castle(Figure.FigureColor.White);
            Cells[0, 7].Figure = new Castle(Figure.FigureColor.Black);
            Cells[7, 7].Figure = new Castle(Figure.FigureColor.Black);

            Cells[1, 0].Figure = new Horse(Figure.FigureColor.White);
            Cells[6, 0].Figure = new Horse(Figure.FigureColor.White);
            Cells[1, 7].Figure = new Horse(Figure.FigureColor.Black);
            Cells[6, 7].Figure = new Horse(Figure.FigureColor.Black);

            Cells[2, 0].Figure = new Officer(Figure.FigureColor.White);
            Cells[5, 0].Figure = new Officer(Figure.FigureColor.White);
            Cells[2, 7].Figure = new Officer(Figure.FigureColor.Black);
            Cells[5, 7].Figure = new Officer(Figure.FigureColor.Black);

            Cells[3, 0].Figure = new Queen(Figure.FigureColor.White);
            Cells[4, 0].Figure = new King(Figure.FigureColor.White);
            Cells[4, 7].Figure = new King(Figure.FigureColor.Black);
            Cells[3, 7].Figure = new Queen(Figure.FigureColor.Black);

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
