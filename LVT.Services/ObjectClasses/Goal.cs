﻿using LVT.LVT.Interfaces;
using System.Collections.Generic;

namespace LVT.Services.ObjectClasses
{
    public class Goal : Node, INode
    {
        public Goal(string title) : base(title)
        {
            ContentLineOne = title;
        }

        public List<Bet> Bets { get; set; }
    }
}
