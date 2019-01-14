using LVT.Services.ObjectClasses;

namespace LVT.Interfaces
{
    public interface IVisionToINodePresentableConverter
    {
        INodePresentable ConvertToNodePresentable(Vision vision);
    }
}
