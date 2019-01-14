using LVT.Interfaces;
using System;
using System.Collections.Generic;

namespace LVT.Services
{
    class NodePresentable : INodePresentable
    {
        public NodePresentable(string id, IEnumerable<string> contentLinesToDisplay, IEnumerable<INodePresentable> subnodes)
        {
            Id = id;
            ContentLinesToDisplay = contentLinesToDisplay;
            Subnodes = subnodes;
        }

        public IEnumerable<string> ContentLinesToDisplay { get; private set;  }
        public string Id { get; }
        public IEnumerable<INodePresentable> Subnodes { get; }
    }
}
