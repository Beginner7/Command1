using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using WebApiServer.Models;
using System.Web.Script.Serialization;

namespace ChessClient
{
    public class Server
    {
        public Server(string address)
        {
            ServerAddress = new Uri(address);
            Jss = new JavaScriptSerializer();
            Encoder = new ASCIIEncoding();
            Client = new HttpClient();
            Client.BaseAddress = ServerAddress;
        }

        public User Login(string login, string psw)
        {
            // Запрос к базе данных для получения
            // id пользователя
            UserLogInData usr = new UserLogInData{ Login = login, Password = psw};
            HttpContent content = new ByteArrayContent(Encoder.GetBytes(Jss.Serialize(usr)));
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = Client.PostAsync("api/user/", content).Result;
            if (response.IsSuccessStatusCode)
            {
                return new User(Jss.Deserialize<UInt64>(response.Content.ReadAsStringAsync().Result));
            }
            
            throw new Exception("No such user or bad login/password");
        }

        public User Register(string login, string psw)
        {
            // Запрос на создание новой записи в таблице Client
            // В случае успеха - автоматический логин пользователя
            User usr = new User{ Id = 000, Login = login, Password = psw};
            HttpContent content = new ByteArrayContent(Encoder.GetBytes(Jss.Serialize(usr)));
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = Client.PutAsync("api/user/", content).Result;
            if (response.IsSuccessStatusCode)
            {
                return Jss.Deserialize<User>(response.Content.ReadAsStringAsync().Result);
            }
            throw new Exception("Unable to create user");
        }

        public ASCIIEncoding Encoder { get; private set; }
        public JavaScriptSerializer Jss { get; private set; }
        public HttpClient Client { get; private set; }
        public Uri ServerAddress { get; private set; }
    }
}
