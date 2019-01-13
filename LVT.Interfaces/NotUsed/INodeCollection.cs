using System.Collections.Generic;

namespace LVT.LVT.Interfaces
{
    public interface INodeCollection
    {
        //not used - haven't managed to get Json deserialiser to deserialise to 'generic'
        IEnumerable<INode> Subnodes { get; }
    }
}
