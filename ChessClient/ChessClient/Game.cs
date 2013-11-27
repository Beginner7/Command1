using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessClient
{
    class Game
    {
        public Game(User firstPlayerUser, long id)
        {
            this.Board = new ChessBoard();
            this.FirstPlayer = firstPlayerUser;
            this.SecondPlayer = null;
            this.Id = id;
        }

        public bool MakeMove(string move)
        {
            if (FirstPlayer.turn)
            {
                Board.CanMove(FirstPlayer, move);
            }
            else
            {
                Board.CanMove(SecondPlayer, move);
            }
        }

        public void GiveUp(User Player)
        {
            
        }

        

        public ChessBoard Board { get; private set; }
        public User FirstPlayer { get; private set; }
        public User SecondPlayer { get; private set; }
        public long Id { get; private set; }
    }
}
