using Interface.Base;

namespace Context
{
    class ModelContext:IContext
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
            injector.RegisterModel(new MainModel());
        }
    }
}
