using LVT.LVT.Interfaces;
using System.Collections.Generic;

namespace LVT.Services.ObjectClasses
{
    public class Initiative : Node, INode
    {
        public Initiative(string title) : base(title)
        {
            ContentLineOne = title;
        }

        public List<Measure> Measures { get; set; }
        public List<Epic> Epics { get; set; }
    }
}