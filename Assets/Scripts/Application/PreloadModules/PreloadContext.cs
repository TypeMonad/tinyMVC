using Interface.Base;

public class PreloadContext : IContext 
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
        //register:injector.RegisterController(new XController);
    }
}
