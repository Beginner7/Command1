using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessClient
{
    class User: IUser
    {
        public User(long id)
        {
            this.Id = id;
        }

        public List<Game> GetOpenGamesList()
        {
            List<Game> serverResponse = new List<Game>(n);
            return from game in serverResponse 
                where game.FirstPlayerId == this.Id && game.finished == false 
                select game;
        }

        public List<Game> GetInterruptedGamesList()
        {
            List<Game> serverResponse = new List<Game>(n);
            return from game in serverResponse
                   where game.SecondPlayerId == this.Id && game.finished == false
                   select game;
        }

        public Game CreateGame(Color color)
        {
            return new Game(this, 0000);
        }


        public long Id { get; private set; }
        public enum Color
        {
            Black,
            White
        }
    }
}
