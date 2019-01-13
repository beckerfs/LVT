using LVT.LVT.Interfaces;
using System.Collections.Generic;

namespace LVT.Services.ObjectClasses
{
    public class Bet : Node, INode
    {        
        public Bet(string title) : base(title)
        {
            ContentLineOne = title;
        }

        public List<Initiative> Initiatives { get; set; }
    }
}
