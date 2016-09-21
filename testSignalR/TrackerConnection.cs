using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;

namespace testSignalR
{
    public class TrackerConnection : PersistentConnection
    {
        //protected override Task OnConnected(IRequest request, string connectionId)
        //{
        //    return Connection.Send(connectionId, "Welcome!");
        //}

        protected override Task OnReceived(IRequest request, string connectionId, string data)
        {
            return Connection.Broadcast(data);
        }
    }
}