using System;
using System.Runtime.Serialization.Formatters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChessClient;
using System.Net.Http;
using System.Net;
using System.Data.SqlClient;

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
        [TestMethod]
        public void DBConnect()
        {
            var connection = new SqlConnection("Server=20a06137-e97e-4681-a96b-a28300d56ae5.sqlserver.sequelizer.com;Database=db20a06137e97e4681a96ba28300d56ae5;User ID=wpkumwollezvaiac;Password=Su6gQSHSsNJt4YGfF7ou7h76jteYWYYm8bmP2tvicPDYroEKJXscgNiKwa5wMR5B;");
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Client";
            command.CommandTimeout = 20;
            command.CommandType = System.Data.CommandType.Text;
            command.ExecuteReader();
        }

    }
}
