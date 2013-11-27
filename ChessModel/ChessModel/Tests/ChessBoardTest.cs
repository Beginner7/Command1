using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChessModel.Board;
using ChessModel.Figure;
using NUnit.Framework;

namespace ChessModel.Tests
{
    [TestFixture]
    class ChessBoardTest
    {
        [Test]
        public void MovePawn()
        {
            Pawn p = new Pawn(Figure.Figure.FigureColor.White);
            Assert.AreEqual(true, p.CanMove(new CellMove("e2-e4")));
            Assert.AreEqual(false, p.CanMove(new CellMove("e2-e5")));
            Assert.AreEqual(false, p.CanMove(new CellMove("e2-a3")));
            Assert.AreEqual(true, p.CanMove(new CellMove("a2-a3")));
            Assert.AreEqual(false, p.CanMove(new CellMove("b5-b7")));

            Pawn pb = new Pawn(Figure.Figure.FigureColor.Black);
            Assert.AreEqual(false, pb.CanMove(new CellMove("e2-e4")));
            Assert.AreEqual(true, pb.CanMove(new CellMove("b7-b6")));
            Assert.AreEqual(false, pb.CanMove(new CellMove("b4-b2")));
            Assert.AreEqual(false, pb.CanMove(new CellMove("a5-b4")));
            Assert.AreEqual(true, pb.CanMove(new CellMove("g4-g3")));

        }

        [Test]
        public void KillPawn()
        {
            Pawn p = new Pawn(Figure.Figure.FigureColor.White);
            Pawn pb = new Pawn(Figure.Figure.FigureColor.Black);

            //Assert.AreEqual(true, p.CanKill(new CellMove("e3-d4")));
            //Assert.AreEqual(false, p.CanKill(new CellMove("e3-e4")));
            //Assert.AreEqual(false, p.CanKill(new CellMove("f3-e2")));
            //Assert.AreEqual(false, p.CanKill(new CellMove("e3-g1")));

            Assert.AreEqual(true, pb.CanKill(new CellMove("b7-a6")));
            Assert.AreEqual(true, pb.CanKill(new CellMove("b7-c6")));
            Assert.AreEqual(false, pb.CanKill(new CellMove("c6-a5")));
            Assert.AreEqual(false, pb.CanKill(new CellMove("b7-a8")));
        }

        [Test]
        public void MoveAndKillCastle()
        {
            Castle c = new Castle(Figure.Figure.FigureColor.White);
            Assert.AreEqual(true, c.CanKill(new CellMove("a1-a8")));
            Assert.AreEqual(true, c.CanKill(new CellMove("a1-h1")));
            Assert.AreEqual(false, c.CanKill(new CellMove("a1-b2")));
            Assert.AreEqual(true, c.CanKill(new CellMove("d4-d1")));

        }


        [Test]
        public void MoveAndKillHorse()
        {
            Horse h = new Horse(Figure.Figure.FigureColor.White);

            Assert.AreEqual(true, h.CanKill(new CellMove("b1-d2")));
            Assert.AreEqual(true, h.CanKill(new CellMove("b1-c3")));
            Assert.AreEqual(false, h.CanKill(new CellMove("b1-c2")));
            Assert.AreEqual(false, h.CanKill(new CellMove("c1-c3")));
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

    }
}
