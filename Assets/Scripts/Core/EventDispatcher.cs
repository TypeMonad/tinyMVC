using Interface.Base;
using System;
using System.Collections.Generic;

public class EventDispatcher :IEventDispatcher
{
    private IDictionary<string, Action<IEvent>> callBacks = new Dictionary<string, Action<IEvent>>();


    public void AddEventListener(string type, Action<IEvent> function)
    {
        if (!callBacks.ContainsKey(type))
        {
            callBacks[type] = function;
        }
        else
        {
            callBacks[type] += function;
        }
    }

    public void RemoveEventListener(string type, Action<IEvent> function)
    {
        if (callBacks.ContainsKey(type))
        {
            callBacks[type] -= function;
            if (callBacks[type] == null)
                callBacks.Remove(type);
        }
    }
    public void DispatchEvent(IEvent e)
    {
        if (callBacks.ContainsKey(e.type))
        {
            e.target = this;
            callBacks[e.type](e);
        }
    }

    public void RemoveListeners(string type)
    {
        if (callBacks.ContainsKey(type))
        {
            callBacks.Remove(type);
        }
    }

    public void RemoveAllListener()
    {
        callBacks.Clear();
    }

    public void Dispose()
    {
        RemoveAllListener();
    }
    
}
