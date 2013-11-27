using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessClient
{
    class Json
    {
        public static byte[] JsonSend(string jsonType, string login, string password)
        {
            switch (jsonType)
            {
                case "login":
                    return byte[] something; // Запрос к серверу на логин
                    break;
                case "register":
                    return byte[] something;
                    break;
                default:
                    // Сообщение об ошибке
            }
        }

        public static User JsonResponse(string jsonType)
        {
            switch (jsonType)
            {
                case "login":
                    User user = new User();
                    return user; // Запрос к серверу на логин
                    break;
                case "register":
                    User user = new User();
                    return user;
                    break;
                default:
                    // Сообщение об ошибке
            }
        }
    }
}
