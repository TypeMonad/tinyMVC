using UnityEngine;
using Interface.Base;
using System.Collections.Generic;
using System;

public class BaseView : MonoBehaviour,IEventDispatcher,IView
{
    private IEntry context;
    protected EventDispatcher dispatcher;

    public BaseView()
    {
        dispatcher = new EventDispatcher();
    }
    public virtual void Start()
    {
        context = GameObject.Find("coreGameContext").GetComponent("GameMain") as IEntry;//hacky
        context.injector.RegisterView(this);
    }	

    public void AddEventListener(string type, Action<IEvent> function)
    {
        dispatcher.AddEventListener(type, function);
    }

    public void RemoveEventListener(string type, Action<IEvent> function)
    {
        if (dispatcher != null)
        {
            dispatcher.RemoveEventListener(type, function);
        }
    }
    public void DispatchEvent(IEvent e)
    {
        dispatcher.DispatchEvent(e);
    }

    public void RemoveListeners(string type)
    {
        dispatcher.RemoveListeners(type);
    }

    public void RemoveAllListener()
    {
        if (dispatcher!=null)
        {
            dispatcher.RemoveAllListener();
        }       
    }

    public virtual void Dispose()
    {
        RemoveAllListener();
        dispatcher = null;
        context = null;
    }

   

    public virtual int ModelId
    {
        get
        {
            return -1;
        }
    }

    public virtual int[] OtherModelId
    {
        get
        {
            return null;
        }
    }


    public virtual void InjectModel(IModel modelI)
    {
        
    }

    public virtual void InjectOtherModels(List<IModel> modelsI)
    {
        
    }

    void OnDestroy()
    {
        Dispose();
    }
}
