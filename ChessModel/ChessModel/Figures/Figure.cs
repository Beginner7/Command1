using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChessModel.Board;

namespace ChessModel.Figures
{
    public abstract class Figure
    {
        public Figure(FigureColor color, FigureType type)
        {
            this.color = color;
            this.type = type;
        }

        public abstract bool CanMove(CellMove move);
        public abstract bool CanKill(CellMove move);

        public enum FigureColor { White, Black };
        public enum FigureType { Pawn, Castle, Horse, Officer, Queen, King };
        private FigureColor color;
        public FigureColor GetColor { get { return color; } }
        private FigureType type;
        public FigureType GetFigureType { get { return type; }}
    }

    public class Pawn : Figure
    {
        public Pawn(FigureColor color) : base(color, FigureType.Pawn) { }
        public override bool CanMove(CellMove move)
        {
            int distanceX = move.End.X - move.Begin.X;
            int distanceY = move.End.Y - move.Begin.Y;
            if (GetColor == FigureColor.White)
            {              
                if (distanceY > 1 && move.Begin.Y != 1 || distanceY > 2)
                    return false;
                if (distanceX != 0)
                    return false;
            }
            else
            {
                if (distanceY > -1 && move.Begin.Y != 6 || distanceY <= -2)
                    return false;
                if (distanceX != 0)
                    return false; 
            }

            return true;
        }

        public override bool CanKill(CellMove move)
        {
            int distanceX = move.End.X - move.Begin.X;
            int distanceY = move.End.Y - move.Begin.Y;

            if (GetColor == FigureColor.White)
            {
                if (Math.Abs(distanceX) != 1 || distanceY != 1)
                    return false;
            }
            else
            {
                if (Math.Abs(distanceX) != 1 || distanceY != -1)
                    return false;
            }

            return true;
        }
    }

    public class Castle : Figure
    {
        public Castle(FigureColor color) : base(color, FigureType.Castle) { }

        public override bool CanMove(CellMove move)
        {
            int distanceX = Math.Abs(move.End.X - move.Begin.X);
            int distanceY = Math.Abs(move.End.Y - move.Begin.Y);

            if (distanceX != 0 && distanceY != 0)
                return false;
            
            return true;
        }

        public override bool CanKill(CellMove move)
        {
            return CanMove(move);
        }
    }

    public class Horse : Figure
    {
        public Horse(FigureColor color) : base(color, FigureType.Horse) { }

        public override bool CanMove(CellMove move)
        {
            int distanceX = Math.Abs(move.End.X - move.Begin.X);
            int distanceY = Math.Abs(move.End.Y - move.Begin.Y);

            if (distanceX == 2 && distanceY == 1)
                return true;
            if (distanceX == 1 && distanceY == 2)
                return true;

            return false;
        }

        public override bool CanKill(CellMove move)
        {
            return CanMove(move);
        }
    }

    public class Officer : Figure
    {
        public Officer(FigureColor color) : base(color, FigureType.Officer) { }

        public override bool CanMove(CellMove move)
        {
            int distanceX = Math.Abs(move.End.X - move.Begin.X);
            int distanceY = Math.Abs(move.End.Y - move.Begin.Y);

            if (distanceX != distanceY)
                return false;
            
            return true;
        }

        public override bool CanKill(CellMove move)
        {
            return CanMove(move);
        }
    }

    public class Queen : Figure
    {
        public Queen(FigureColor color) : base(color, FigureType.Queen) { }

        public override bool CanMove(CellMove move)
        {
            int distanceX = Math.Abs(move.End.X - move.Begin.X);
            int distanceY = Math.Abs(move.End.Y - move.Begin.Y);

            if (distanceX == distanceY)
                return true;

            if (distanceX == 0 || distanceY == 0)
                return true;

            return false;
        }

        public override bool CanKill(CellMove move)
        {
            return CanMove(move);
        }
    }
    
    public class King : Figure
    {
        public King(FigureColor color) : base(color, FigureType.King) { }

        public override bool CanMove(CellMove move)
        {
            int distanceX = Math.Abs(move.End.X - move.Begin.X);
            int distanceY = Math.Abs(move.End.Y - move.Begin.Y);

            if (distanceX > 1 || distanceY > 1)
                return false;

            return true;
        }

        public override bool CanKill(CellMove move)
        {
            return CanMove(move);
        }
    }


}
