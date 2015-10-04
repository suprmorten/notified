using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalRNotify.Hubs
{
    [HubName("notify")]
    public class NotifyHub : Hub
    {
    }
}