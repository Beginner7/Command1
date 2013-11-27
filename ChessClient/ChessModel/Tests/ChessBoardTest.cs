using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChessModel.Board;
using ChessModel.Figures;
using NUnit.Framework;

namespace ChessModel.Tests
{
    [TestFixture]
    class ChessBoardTest
    {
        [Test]
        public void MovePawn()
        {
            Pawn p = new Pawn(Figures.Figure.FigureColor.White);
            Assert.AreEqual(true, p.CanMove(new CellMove("e2-e4")));
            Assert.AreEqual(false, p.CanMove(new CellMove("e2-e5")));
            Assert.AreEqual(false, p.CanMove(new CellMove("e2-a3")));
            Assert.AreEqual(true, p.CanMove(new CellMove("a2-a3")));
            Assert.AreEqual(false, p.CanMove(new CellMove("b5-b7")));

            Pawn pb = new Pawn(Figures.Figure.FigureColor.Black);
            Assert.AreEqual(false, pb.CanMove(new CellMove("e2-e4")));
            Assert.AreEqual(true, pb.CanMove(new CellMove("b7-b6")));
            Assert.AreEqual(false, pb.CanMove(new CellMove("b4-b2")));
            Assert.AreEqual(false, pb.CanMove(new CellMove("a5-b4")));
            Assert.AreEqual(true, pb.CanMove(new CellMove("g4-g3")));

        }

        [Test]
        public void KillPawn()
        {
            Pawn p = new Pawn(Figures.Figure.FigureColor.White);
            Pawn pb = new Pawn(Figures.Figure.FigureColor.Black);

            Assert.AreEqual(true, p.CanKill(new CellMove("e3-d4")));
            Assert.AreEqual(false, p.CanKill(new CellMove("e3-e4")));
            Assert.AreEqual(false, p.CanKill(new CellMove("f3-e2")));
            Assert.AreEqual(false, p.CanKill(new CellMove("e3-g1")));

            Assert.AreEqual(true, pb.CanKill(new CellMove("b7-a6")));
            Assert.AreEqual(true, pb.CanKill(new CellMove("b7-c6")));
            Assert.AreEqual(false, pb.CanKill(new CellMove("c6-a5")));
            Assert.AreEqual(false, pb.CanKill(new CellMove("b7-a8")));
        }

        [Test]
        public void MoveAndKillCastle()
        {
            Castle c = new Castle(Figures.Figure.FigureColor.White);
            Assert.AreEqual(true, c.CanKill(new CellMove("a1-a8")));
            Assert.AreEqual(true, c.CanKill(new CellMove("a1-h1")));
            Assert.AreEqual(false, c.CanKill(new CellMove("a1-b2")));
            Assert.AreEqual(true, c.CanKill(new CellMove("d4-d1")));

        }


        [Test]
        public void MoveAndKillHorse()
        {
            Horse h = new Horse(Figures.Figure.FigureColor.White);

            Assert.AreEqual(true, h.CanKill(new CellMove("b1-d2")));
            Assert.AreEqual(true, h.CanKill(new CellMove("b1-c3")));
            Assert.AreEqual(false, h.CanKill(new CellMove("b1-c2")));
            Assert.AreEqual(false, h.CanKill(new CellMove("c1-c3")));
        }

        [Test]
        public void OfficerKillMove()
        {
            Officer officer = new Officer(Figures.Figure.FigureColor.Black);

            Assert.AreEqual(true, officer.CanKill(new CellMove("c1-f4")));
            Assert.AreEqual(false, officer.CanKill(new CellMove("c1-a4")));
            Assert.AreEqual(true, officer.CanKill(new CellMove("a1-h8")));
            Assert.AreEqual(false, officer.CanKill(new CellMove("d4-d1")));
        }
        [Test]
        public void QueenKillMove()
        {
            Queen queen = new Queen(Figures.Figure.FigureColor.White);

            Assert.AreEqual(true, queen.CanKill(new CellMove("a1-a8")));
            Assert.AreEqual(true, queen.CanKill(new CellMove("a1-h1")));
            Assert.AreEqual(true, queen.CanKill(new CellMove("a1-b2")));
            Assert.AreEqual(true, queen.CanKill(new CellMove("d4-d1")));

            Assert.AreEqual(true, queen.CanKill(new CellMove("c1-f4")));
            Assert.AreEqual(false, queen.CanKill(new CellMove("c1-a4")));
            Assert.AreEqual(true, queen.CanKill(new CellMove("a1-h8")));
            Assert.AreEqual(true, queen.CanKill(new CellMove("d4-d1")));
        }

        [Test]
        public void KingKillMove()
        {
            King king = new King(Figures.Figure.FigureColor.White);

            Assert.AreEqual(true, king.CanKill(new CellMove("e1-e2")));
            Assert.AreEqual(true, king.CanKill(new CellMove("d4-e3")));
            Assert.AreEqual(true, king.CanKill(new CellMove("e4-d4")));
            Assert.AreEqual(false, king.CanKill(new CellMove("e1-c3")));
            Assert.AreEqual(false, king.CanKill(new CellMove("e1-g1")));
        }

        [Test]
        public void CellPosition()
        {
            CellPosition c = new CellPosition("e2");
            Assert.AreEqual(c.X, 4);
            Assert.AreEqual(c.Y, 1);
            CellPosition c1 = new CellPosition("g7");
            Assert.AreEqual(c1.X, 6);
            Assert.AreEqual(c1.Y, 6);
        }

        [Test]
        public void Pawn_e2_e4()
        {
            ChessBoard board = new ChessBoard();

            Pawn figure = board.GetCell(new CellPosition("e2")).Figure as Pawn;
            Assert.IsNotNull(figure);

            Figure f = board.GetCell(new CellPosition("e4")).Figure;

            Assert.IsNull(f);

            //bool moveResult

        }


    }
}
