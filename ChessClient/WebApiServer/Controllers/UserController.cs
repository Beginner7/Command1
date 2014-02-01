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
        public HttpResponseMessage GetUserNameById(Int64 id)
        {
            
            //TODO:implementation here
            return new JsonHttpResponseMessage(HttpStatusCode.OK, typeof(User),Models.User.GetUserName(id));
        }
        [HttpPut]
        public HttpResponseMessage CreateUser([FromBody] User user)
        {
            try
            {
                user.Create();
            }
            catch (InvalidOperationException e)
            {
                return new JsonHttpResponseMessage(HttpStatusCode.InternalServerError, typeof(string), e.Message);
            }
            return new JsonHttpResponseMessage(HttpStatusCode.OK, typeof(User), user);
        }
        [HttpPost]
        public HttpResponseMessage Login([FromBody] UserLogInData user)
        {
            //TODO:implementation here
            Int64 userId;
            try
            {
                userId=Models.User.login(user).Id;
            }
            catch (ArgumentException e)
            {
                return new JsonHttpResponseMessage(HttpStatusCode.InternalServerError, typeof(string), e.Message);
            }
            return new JsonHttpResponseMessage(HttpStatusCode.OK, typeof(Int64), userId); 
        }
        [HttpPost]
        public HttpResponseMessage ChangeUser([FromBody] User user, [FromUri]UInt64 id)
        {
            //TODO:implementation here
            try
            {
                
            }
            catch (Exception)
            {
                
                throw;
            }
            return new JsonHttpResponseMessage(HttpStatusCode.OK, typeof(User), user);
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
