using UnityEngine;
using Interface.Base;
using System.Collections.Generic;

public class TestView : BaseView 
{
    private MainModel model;
    private MainModel otherModelA;

	
    public override void Start()
    {
        base.Start();
        Debug.Log("Start model:" + model);
        Debug.Log("Start otherModelA:" + otherModelA);
    }   
    
	void Update () 
	{        
	}
    public override int ModelId
    {
        get
        {
            return ModelIdConst.TEST;
        }
    }
    public override int[] OtherModelId
    {
        get
        {
            return new int[]{ModelIdConst.GAME_MAIN};
        }
    }

    public override void Dispose()
    {
        base.Dispose();  
        //..
    }



    public override void InjectModel(IModel modelI)
    {
        model = modelI as MainModel;
    }

    public override void InjectOtherModels(List<IModel> modelsI)
    {
        otherModelA = modelsI[0] as MainModel;
    }

}
