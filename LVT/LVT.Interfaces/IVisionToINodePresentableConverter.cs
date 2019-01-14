using LVT.Services.ObjectClasses;

namespace LVT.Interfaces
{
    public interface IVisionToINodePresentableConverter
    {
        INodePresentable ConvertToINodePresentable(Vision vision);
    }
}
