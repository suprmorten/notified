using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Newtonsoft.Json;
using SignalRNotify.Hubs;

namespace SignalRNotify.Controllers
{
    public class NotifyController : ApiControllerWithHub<NotifyHub>
    {
        [Route("api/notify/send")]
        public void Send(object request)
        {
            Hub.Clients.All.message(JsonConvert.SerializeObject(request));
        }
    }

    public class NotifyRequest
    {
        public string Message { get; set; }
    }
}