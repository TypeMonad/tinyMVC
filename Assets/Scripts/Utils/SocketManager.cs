using Interface.Base;
using System.Collections.Generic;
using System.Net.Sockets;
using System.IO;

namespace Utils
{
    public class StateObject
    {
        public Socket WorkSocket = null;
        public const int BufferSize = 256;
        public byte[] Buffer = new byte[BufferSize];
        public MemoryStream MS = new MemoryStream();
        public SocketManager Manager;
        public long ReadPos = 0;
        public long WritePos = 0;
    }

    public class SocketManager: EventDispatcher
    {
        private Socket mSocket = null;
        private IDictionary<int, ISocketHandler> callBacks = new Dictionary<int, ISocketHandler>();
    }
}


