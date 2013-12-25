using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiServer.Models;
using WebApiServer.Not_MVC_code;
using System.Data.SqlClient;

namespace WebApiServer.Controllers
{
    public class UserController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetUserNameById(UInt64 id)
        {
            //TODO:implementation here
            return new JsonHttpResponseMessage(HttpStatusCode.OK, typeof(string), "TestUser "+id);
        }
        [HttpPut]
        public HttpResponseMessage CreateUser([FromBody] User user)
        {
            var result = DBRequest();

            //return new JsonHttpResponseMessage(HttpStatusCode.OK, typeof(User), user); ;
            return new JsonHttpResponseMessage(HttpStatusCode.OK, typeof(string), result.ToString());
        }
        [HttpPost]
        public HttpResponseMessage Login([FromBody] UserLogInData user)
        {
            //TODO:implementation here

            return new JsonHttpResponseMessage(HttpStatusCode.OK, typeof(UInt64), 45878); ;
        }
        [HttpPost]
        public HttpResponseMessage ChangeUser([FromBody] User user, [FromUri]UInt64 id)
        {
            //TODO:implementation here

            return new JsonHttpResponseMessage(HttpStatusCode.OK, typeof(User), new User{Id=1,Login = "fg",Password = "rr"});
        }

        private SqlDataReader DBRequest()
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Client";
            command.CommandTimeout = 20;
            command.CommandType = System.Data.CommandType.Text;
            return command.ExecuteReader();
        }

        private SqlConnection connection = new SqlConnection("Server=20a06137-e97e-4681-a96b-a28300d56ae5.sqlserver.sequelizer.com;Database=db20a06137e97e4681a96ba28300d56ae5;User ID=wpkumwollezvaiac;Password=Su6gQSHSsNJt4YGfF7ou7h76jteYWYYm8bmP2tvicPDYroEKJXscgNiKwa5wMR5B;");
    }
}
