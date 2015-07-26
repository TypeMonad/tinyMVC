using UnityEngine;
using core;
using Interface.Base;

namespace Context
{
    public sealed class GameMain : MonoBehaviour,IEntry
    {        
        private ModelContext modelContext;
        private Injector register;
        private ControllerContext controllerContext;
        private PreloadContext preloadContext;
        private LongLiveContext longLiveContext;
        private RuntimeContext runtimeContext;
        static bool Initialed = false; 
        void Awake()
        {
            Init();          
        }       

        private void Init()
        {
            InitContext();
            InitModels();
            InitControllers();
        }

        private void InitContext()
        {
            register = new Injector();
            register.SetManager(new Manager());
        }       
        void Update()
        {
        }
        public void InitModels()
        {
            modelContext = new ModelContext();
            modelContext.Injector = register;
            modelContext.Setup();
        }

        public void InitControllers()
        {            
            controllerContext = new ControllerContext();
            controllerContext.Injector = register;
            controllerContext.Setup();

            preloadContext = new PreloadContext();
            preloadContext.Injector = register;
            preloadContext.Setup();

            longLiveContext = new LongLiveContext();
            longLiveContext.Injector = register;
            longLiveContext.Setup();

            runtimeContext = new RuntimeContext();
            runtimeContext.Injector = register;
            runtimeContext.Setup();
        }

        public IInjector injector
        {
            get
            {
                return register;
            }
        }
    }
}

