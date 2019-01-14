using LVT.LVT.Interfaces;
using System;
using System.Collections.Generic;

namespace LVT.Services.ObjectClasses
{
    public abstract class Node : INode
    {
        public Node(string contentLineOne)
        {
            Id = Guid.NewGuid().ToString();
            Type = GetType().Name;
            ContentLineOne = contentLineOne;
        }
        public string Id { get ; set ; }
        public string Type { get; set; }
        public string ContentLineOne { get ; set ; }

        public IEnumerable<string> CollectProperties()
        {
            return new List<string>
            {
                Type,
                ContentLineOne
            };
        }
    }
}
