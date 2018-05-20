using System;
using System.Net;
using System.Net.Http;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.WebSockets;

namespace WebSockets.Web.Controllers
{
    public class NotificationController : ApiController
    {
        public HttpResponseMessage Get()
        {
            if(HttpContext.Current.IsWebSocketRequest)
            {
                HttpContext.Current.AcceptWebSocketRequest(Connect);
            }
            return new HttpResponseMessage(HttpStatusCode.SwitchingProtocols);
        }

        private async Task Connect(AspNetWebSocketContext context)
        {
            WebSocket socket = context.WebSocket;
            while (true)
            {
                ArraySegment<byte> buffer = new ArraySegment<byte>(new byte[1024]);
                if (socket.State == WebSocketState.Open)
                {
                    var notification = string.Format("Time is now {0}", DateTime.Now.ToLongTimeString());
                    buffer = new ArraySegment<byte>(Encoding.UTF8.GetBytes(notification));

                    await socket.SendAsync(buffer, WebSocketMessageType.Text, true, CancellationToken.None);
                }
                else
                {
                    break;
                }
                Thread.Sleep(1000);
            }
        }
    }
}
