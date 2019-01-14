using LVT.LVT.Interfaces;
using System.Collections.Generic;

namespace LVT.Services.ObjectClasses
{
    public class Vision : Node, INode
    {
        public Vision(string title) : base(title)
        {
            ContentLineOne = title;
            Goals = new List<Goal>();
        }

        public List<Goal> Goals { get; set; }
    }
}
