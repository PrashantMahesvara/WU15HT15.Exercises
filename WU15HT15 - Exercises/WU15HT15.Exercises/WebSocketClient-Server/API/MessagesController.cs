using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace WebSocketClient_Server.API
{
    public class MessagesController : ApiController
    {
        public HttpResponseMessage Get(string alias)
        {
            HttpContext.Current.AcceptWebSocketRequest(new MessageWebSocketHandler(alias));
            return Request.CreateResponse(HttpStatusCode.SwitchingProtocols);
        }

        public class MessageWebSocketHandler : WebSocketHandler
        {
            private static readonly WebSocketCollection MessageClients = new WebSocketCollection();
            private readonly string alias;

            public MessageWebSocketHandler(string alias)
            {
                this.alias = alias;
            }

            public override void OnOpen()
            {
                MessageClients.Add(this);
            }

            public override void OnMessage(string message)
            {
                var response = string.Format("{0} wrote <i>  \"{1}\"</i>", alias, message);
                MessageClients.Broadcast(response);
            }
        }
    }
}
