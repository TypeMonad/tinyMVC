using System;

namespace Interface.Base
{
    public interface ISocketHandler:IDisposable
    {
        void handleSocketMsg(int cmdCode, object proto);
    }
}
