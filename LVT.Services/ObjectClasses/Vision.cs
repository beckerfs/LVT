using LVT.LVT.Interfaces;
using LVT.Services.ObjectClasses;
using System.Collections.Generic;
using Newtonsoft.Json;
using LVT.Interfaces;
using System.Linq;

namespace LVT.Services
{
    public class Vision : Node, INodePresentable
    {
        public Vision() : base() { }

        public string Title { private get; set; }
        public List<Goal> Goals { get; set; }

        new public string ContentLineOne => Title;

        new public IList<INodePresentable> SubnodesOne => Goals.Cast<INodePresentable>().ToList();

        public INodePresentable FirstGoalAsINodePresentable()
        {
            return Goals[0];
        }
    }
}
