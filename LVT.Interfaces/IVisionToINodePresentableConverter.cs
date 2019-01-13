using LVT.LVT.Interfaces;
namespace LVT.Interfaces
{
    public interface IVisionToINodePresentableConverter
    {
        INodePresentable ConvertToNodePresentable(INode vision);
    }
}
