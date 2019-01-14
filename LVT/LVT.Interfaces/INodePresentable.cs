using System.Collections.Generic;

namespace LVT.Interfaces
{
    public interface INodePresentable
    {
        string Id { get; }
        IEnumerable<string> ContentLinesToDisplay { get; }
        IEnumerable<INodePresentable> Subnodes { get; }
    }
}
