using Interface.Base;
public interface IInjector
{
    void RegisterController(IController controllerI);
    void RegisterModel(IModel modelI);
    void RegisterView(IView viewI);
    void SetManager(IManager managerI);
}
    

