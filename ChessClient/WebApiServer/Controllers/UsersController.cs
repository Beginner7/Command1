using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiServer.Models;
using WebApiServer.Not_MVC_code;

namespace WebApiServer.Controllers
{
    public class UsersController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetUserById(UInt64 id)
        {
            //TODO:implementation here
            return new JsonHttpResponseMessage(HttpStatusCode.OK, typeof(string), "TestUser "+id);
        }
        [HttpPut]
        public HttpResponseMessage CreateUser([FromBody] User user)
        {
            //TODO:implementation here

            return new JsonHttpResponseMessage(HttpStatusCode.OK, typeof(User), user); ;
        }
        [HttpPost]
        public HttpResponseMessage ChangeUser([FromBody] UserLogInData user)
        {
            //TODO:implementation here

            return new JsonHttpResponseMessage(HttpStatusCode.OK, typeof(UserLogInData), user); ;
        }
        [HttpPost]
        public HttpResponseMessage ChangeUser([FromBody] UserLogInData user, [FromUri]UInt64 id)
        {
            //TODO:implementation here

            return new JsonHttpResponseMessage(HttpStatusCode.OK, typeof(User), new User{Id=1,Login = "fg",Password = "rr"});
        }
        [HttpGet]
        public HttpResponseMessage Test(UInt64 id)
        {
            //TODO:implementation here
            return new JsonHttpResponseMessage(HttpStatusCode.OK, typeof(string), "TestUser " + id);
        }
    }
}
