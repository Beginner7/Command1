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

        public ChessBoard Board { get; private set; }
        public User FirstPlayer { get; private set; }
        public User SecondPlayer { get; private set; }
        public long Id { get; private set; }
    }
}
