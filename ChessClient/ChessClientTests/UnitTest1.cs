using System;
using System.Runtime.Serialization.Formatters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChessClient;
using System.Net.Http;
using System.Net;

namespace ChessClientTests
{
    //[TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        public void ServerConnection()
        {
            var handler = new HttpClientHandler();
            handler.Proxy = new WebProxy("127.0.0.1", 8888);
            Server server = new Server("http://command1.apphb.com/");
            //45878
            User usr = server.Login("lol", "lol");
            Assert.AreEqual((UInt64)45878, usr.Id);

        }

        //[TestMethod]
        public void Registration()
        {
            var handler = new HttpClientHandler();
            handler.Proxy = new WebProxy("127.0.0.1", 8888);
            Server server = new Server("http://command1.apphb.com/");
            User usr = server.Register("login", "password");
            Assert.AreEqual((UInt64)000, usr.Id);
            Assert.AreEqual("login", usr.Login);
            Assert.AreEqual("password", usr.Password);
        }
    }
}
