using LVT.Interfaces;
using LVT.LVT.Interfaces;
using System;
using System.Collections.Generic;

namespace LVT.Services
{
    public abstract class Node : INodePresentable
    {
        public Node()
        {
            Id = Guid.NewGuid().ToString();
            Type = GetType().Name;
        }

        public string Id { get; set; }

        public string Type { get; set; }


        public string ContentLineOne => "hello :-)";

        public string ContentLineTwo => string.Empty;

        public string ContentLineThree => string.Empty;

        public string ContentLineFour => string.Empty;

        public IList<INodePresentable> SubnodesOne => new List<INodePresentable>();

        public IList<INodePresentable> SubnodesTwo => new List<INodePresentable>();
    }
}
