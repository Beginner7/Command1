using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessClient
{
    public class User: IUser
    {
        public User(Int64 id)
        {
            this.Id = id;
        }

        public User()
        {
        }

        public List<Game> GetOpenGamesList()
        {
            // Запрос к серверу возвращает список всех игр
            // Можно сделать так, чтобы сразу возвращался список
            // открытых игр
            List<Game> serverResponse = new List<Game>(10);
            return serverResponse;
            //return from game in serverResponse 
            //    where game.FirstPlayerId == this.Id && game.finished == false 
            //    select game;
        }

        public List<Game> GetInterruptedGamesList()
        {
            // Запрос к серверу возвращает список всех игр
            // Можно сделать так, чтобы сразу возвращался список
            // прерванных игр
            List<Game> serverResponse = new List<Game>(10);
            return serverResponse;
            //return from game in serverResponse
            //    where game.SecondPlayerId == this.Id && game.finished == false
            //    select game;
        }

        public Game CreateGame(Color color)
        {
            // Отправляется запрос к серверу на создание в базе
            // новой записи Party/Game с исходными значениями 
            // некоторых полей (FirstPlayerId и color)
            return new Game(this, 0000);
        }


        public Int64 Id { get; private set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public enum Color
        {
            Black,
            White
        }
    }
}
