using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiServer.Not_MVC_code;

namespace WebApiServer.Controllers
{
    public class StepsController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetUserById(UInt64 gameId)
        {
            //TODO:implementation here
            return new JsonHttpResponseMessage(HttpStatusCode.OK, typeof(string), "TestStep " + gameId);
        }
    }
}
