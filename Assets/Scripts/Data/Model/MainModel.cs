using Interface.Base;

public class MainModel:EventDispatcher,IModel
{
    public int Id
    {
        get { return ModelIdConst.GAME_MAIN; }
    }
}
