using System.Collections.Generic;
namespace Interface.Base
{
    public interface IModelInjection
    {
        void InjectModel(IModel modelI);
        void InjectOtherModels(List<IModel> modelsI);
        int ModelId
        {
            get;
        }
        int[] OtherModelId
        {
            get;
        }
    }
}
