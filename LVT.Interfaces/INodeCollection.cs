using System.Collections.Generic;

namespace LVT.LVT.Interfaces
{
    public interface INodeCollection
    {
        IEnumerable<INode> Subnodes { get; }
    }
}
