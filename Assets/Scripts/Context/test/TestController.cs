
using Interface.Base;
using System.Collections.Generic;

public class TestController:IController, ISocketHandler
{
    private Manager manager;    

    public void InjectModel(IModel modelI)
    {        
    }

    public void InjectOtherModels(List<IModel> modelsI)
    {

    }

    public int ModelId
    {
        get { return ModelIdConst.NONE; }
    }

    public int[] OtherModelId
    {
        get
        {
            return null;
        }
    }

    public void Dispose()
    {
        manager = null;
    }

    public void InjectManager(IManager managerI)
    {
       
    }

    public void handleSocketMsg(int cmdCode, object proto)
    {
       
    }

}
