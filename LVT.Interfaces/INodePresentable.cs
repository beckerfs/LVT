using System.Collections.Generic;

namespace LVT.Interfaces
{
    public interface INodePresentable
    {
        IEnumerable<string> ContentLines { get;  }
        IEnumerable<INodePresentable> Subnodes { get; }
    }
}
