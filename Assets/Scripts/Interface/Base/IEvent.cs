namespace Interface.Base
{
    public interface IEvent
    {
        string type
        {
            get;
        }
        object eventData
        {
            get;
        }
        IEventDispatcher target
        {
            get;
            set;
        }
    }
}
