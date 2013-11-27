using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiServer.Not_MVC_code;
using WebApiServer.Models;

namespace WebApiServer.Controllers
{
    public class GameController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetOpenGames()
        {
            //TODO:implementation here
            return new JsonHttpResponseMessage(HttpStatusCode.OK, typeof(string), "GetOpenGames");
        }
        [HttpGet]
        public HttpResponseMessage GetGameById(UInt64 id)
        {
            //TODO:implementation here
            return new JsonHttpResponseMessage(HttpStatusCode.OK, typeof(string), "GetGameById" + id);
        }
        [HttpPut]
        public HttpResponseMessage CreateGame()
        {
            //TODO:implementation here
            return new JsonHttpResponseMessage(HttpStatusCode.OK, typeof(string), "CreateGame"); 
        }
        [HttpPost]
        public HttpResponseMessage JoinGame([FromBody]UInt64 userId,[FromUri]UInt64 id)
        {
            //TODO:implementation here
            return new JsonHttpResponseMessage(HttpStatusCode.OK, typeof(string), "JoinGame");
        }

    }
}
