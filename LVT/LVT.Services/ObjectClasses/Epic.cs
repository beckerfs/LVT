﻿using LVT.LVT.Interfaces;
using System.Collections.Generic;

namespace LVT.Services.ObjectClasses
{
    public class Epic : Node, INode
    {
        public Epic(string description, string deadline) : base(description)
        {
            ContentLineOne = description;
            ContentLineTwo = deadline;
        }

        public string ContentLineTwo { get; private set; }

        public IEnumerable<string> CollectProperties()
        {
            return new List<string>
            {
                Type,
                ContentLineOne,
                ContentLineTwo
            };           
        }
    }
}