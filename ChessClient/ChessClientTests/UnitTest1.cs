using System;
using System.Runtime.Serialization.Formatters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChessClient;

namespace ChessClientTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ServerConnection()
        {
            Server server = new Server("http://command1.apphb.com/");
            //45878
            User usr = server.Login("lol", "lol");
            Assert.AreEqual((UInt64)45878, usr.Id);

        }

        [TestMethod]
        public void Registration()
        {
            Server server = new Server("http://command1.apphb.com/");
            User usr = server.Register("login", "password");
            Assert.AreEqual((UInt64)000, usr.Id);
            Assert.AreEqual("login", usr.Login);
            Assert.AreEqual("password", usr.Password);
        }
    }
}
