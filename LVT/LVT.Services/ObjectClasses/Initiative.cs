using LVT.LVT.Interfaces;
using System.Collections.Generic;

namespace LVT.Services.ObjectClasses
{
    public class Initiative : Node, INode
    {
        public Initiative(string title) : base(title)
        {
            ContentLineOne = title;
            Measures = new List<Measure>();
            Epics = new List<Epic>();
        }

        public List<Measure> Measures { get; set; }
        public List<Epic> Epics { get; set; }
    }
}