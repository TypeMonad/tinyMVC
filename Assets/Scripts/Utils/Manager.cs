using Interface.Base;
using Utils;

public class Manager:IManager
{
    public SocketManager socketManager;
    public ResourceManager resourceManager;
    public TickManager tickManager;
    public Manager()
    {
        Setup();
    }

    private void Setup()
    {
        socketManager = new SocketManager();
        resourceManager = new ResourceManager();
    }
    //other managers
}

