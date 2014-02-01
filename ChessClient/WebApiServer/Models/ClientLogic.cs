using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiServer.Models
{
    public partial class Client
    {
        public Client(User user)
        {
            id = user.Id;
            login = user.Login;
            password = user.Password;
        }
    }
}