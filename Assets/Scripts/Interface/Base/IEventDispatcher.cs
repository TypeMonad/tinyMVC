using System;

namespace Interface.Base
{
    public interface IEventDispatcher:IDisposable
    {
        void AddEventListener(string type, Action<IEvent> function);
        void RemoveEventListener(string type, Action<IEvent> function);
        void DispatchEvent(IEvent e);
        void RemoveListeners(string type);
        void RemoveAllListener();
    }
}
    