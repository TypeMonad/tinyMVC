using Interface.Base;

public class RuntimeContext : IContext 
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
