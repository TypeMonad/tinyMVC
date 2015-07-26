using System.Net.Sockets;

namespace Interface.Base
{
    public interface ISocketManager:IEventDispatcher
    {
        void Connect(string ip, int port);
        void DisConnect();
        void Close();
        void SetSocket(Socket socket);

        void Send(short cmdCode, object proto);

        void RegisterListener(int cmdCode, ISocketHandler handler);

        void UnRegisterListener(int cmdCode);

        bool Connected();
    }
}
