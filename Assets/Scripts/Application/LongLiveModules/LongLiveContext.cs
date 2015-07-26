using Interface.Base;

public class LongLiveContext : IContext 
{
    private IInjector injector;

    public IInjector Injector
    {
        set
        {
            injector = value;
        }
    }

    public void Setup()
    {
        
    }
}
