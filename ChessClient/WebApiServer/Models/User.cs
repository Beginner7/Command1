using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiServer.Models
{
    public class User
    {
        //TODO:implementation here
        public UInt64 Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}