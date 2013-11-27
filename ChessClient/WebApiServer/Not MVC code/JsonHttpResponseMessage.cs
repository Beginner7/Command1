using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;

namespace WebApiServer.Not_MVC_code
{
    public class JsonHttpResponseMessage : HttpResponseMessage
    {
        public JsonHttpResponseMessage(HttpStatusCode responceStatusCode, Type responseDataType, object responseData)
        {
            dynamic convertedResponceData = Convert.ChangeType(responseData, responseDataType);
            var jss = new JavaScriptSerializer();
            var encoder = new ASCIIEncoding();
            Content = new ByteArrayContent(encoder.GetBytes(jss.Serialize(convertedResponceData)));
            Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        }
    }
}