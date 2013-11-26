using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessClient
{
    interface IUser
    {
        Game CreateGame(User.Color color);
        List<Game> GetOpenGamesList();
        List<Game> GetInterruptedGamesList();
    }
}
