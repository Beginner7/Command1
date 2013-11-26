using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChessClient
{
    class Server
    {
        public Server(string address)
        {
            IPHostEntry ipHost = Dns.GetHostEntry("localhost");
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 11000);

            Connection = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        }

        public User Login(string login, string psw)
        {
            // Запрос к базе данных для получения
            // id пользователя
            Connection.Send(Json.JsonSend("login", login, psw));
            var response = Connection.Receive(Json.JsonResponse("login"));
            if (response != null)
            {
                return response;
            }
            else
            {
                Console.WriteLine("No such user or bad login/password");
            }
        }

        public User Register(string login, string psw)
        {
            // Запрос на создание новой записи в таблице Client
            // В случае успеха - автоматический логин пользователя
            Connection.Send(Json.JsonSend("register", login, psw));
            var response = Connection.Receive(Json.JsonResponse("register"));
            if (response != null)
            {
                return response;
            }
            else
            {
                Console.WriteLine("Unable to create user");
            }
        }

        public Socket Connection { get; private set; }
    }
}
