using System.Collections.Generic;

namespace LVT.LVT.Interfaces
{
    public interface INode
    {
        string Id { get; set;  }
        string Type { get; set;  }
        string ContentLineOne { get; set;  }

        IEnumerable<string> CollectProperties();
    }
}