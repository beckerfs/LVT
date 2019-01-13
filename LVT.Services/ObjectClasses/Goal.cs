using LVT.Interfaces;
using LVT.LVT.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LVT.Services.ObjectClasses
{
    public class Goal : Node, INodePresentable
    {
        public Goal() : base() { }

        public string Title { private get; set; }

        new public string ContentLineOne => Title;


        //[JsonProperty("Bets")]
        public List<Bet> Bets { get; set; }

    }
}
