using Interface.Base;
using System.Collections.Generic;
using UnityEngine;

namespace core
{
    public sealed class Injector : IInjector
    {
        IDictionary<int, IModel> models = new Dictionary<int, IModel>();
        IManager manager;
        public void RegisterModel(IModel modelI)
        {
            if (!models.ContainsKey(modelI.Id))
            {
                models.Add(modelI.Id, modelI);
            }
        }

        public void RegisterController(IController controllerI)
        {
            ModelInject(controllerI);
            controllerI.InjectManager(manager);
        }


        public void RegisterView(IView viewI)
        {
            ModelInject(viewI);
        }

        private void ModelInject(IModelInjection modelObserver)
        {
            if (models.ContainsKey(modelObserver.ModelId))
            {
                modelObserver.InjectModel(models[modelObserver.ModelId]);
            }

            if (modelObserver.OtherModelId != null && modelObserver.OtherModelId.Length > 0)
            {
                List<IModel> otherModels = new List<IModel>();
                foreach (int id in modelObserver.OtherModelId)
                {
                    if (models.ContainsKey(id))
                    {
                        otherModels.Add(models[id]);
                    }
                    else
                    {
                        Debug.Log("warning ^ model not found:" + id);
                    }
                }
                modelObserver.InjectOtherModels(otherModels);
            }
        }


        public void SetManager(IManager managerI)
        {
            manager=managerI;
        }
    }
}
