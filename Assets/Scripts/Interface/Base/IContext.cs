
namespace Interface.Base
{
   public interface IContext
    {
       IInjector Injector
       {
           set;
       }
       void Setup();
    }
}
