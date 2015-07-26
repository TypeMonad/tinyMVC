using System;
using Interface.Base;

public class CustomEvent: EventArgs, IEvent
{
    private object mEventData;
    protected string eventType;
    protected IEventDispatcher mTarget;
    public CustomEvent(string type, Object data=null)
    {
        eventType = type;
        mEventData = data;
    }
    
    public string type
    {
        get
        {
            return eventType;
        }
    }

    public IEventDispatcher target
    {
        get
        {
            return mTarget;
        }
        set
        {
            mTarget = value;
        }
    }

    public object eventData
    {
        get
        {
            return mEventData;
        }        
    }
}
