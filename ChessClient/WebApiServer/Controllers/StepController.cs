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
    public class StepController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetStepsByGameId(UInt64 gameId)
        {
            //TODO:implementation here
            return new JsonHttpResponseMessage(HttpStatusCode.OK, typeof(string), "GetStepsByGameId" + gameId);
        }
        [HttpPut]
        public HttpResponseMessage MakeStep([FromUri]UInt64 gameId,[FromBody]Step step)
        {
            //TODO:implementation here
            return new JsonHttpResponseMessage(HttpStatusCode.OK, typeof(string), "MakeStep " + gameId);
        }
        [HttpDelete]
        public HttpResponseMessage CancelStep([FromUri]UInt64 gameId)
        {
            //TODO:implementation here
            return new JsonHttpResponseMessage(HttpStatusCode.OK, typeof(string), "CancelStep " + gameId);
        }
    }
}
