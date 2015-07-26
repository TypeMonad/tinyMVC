using Interface.Base;

namespace Context
{
    class ControllerContext:IContext
    {
        private IInjector injector;

        public IInjector Injector
        {
            set
            {
                injector=value;
            }
        }

        public void Setup()
        {
            injector.RegisterController(new TestController());
        }
    }
}
