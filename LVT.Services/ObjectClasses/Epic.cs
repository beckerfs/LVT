using LVT.LVT.Interfaces;
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

        public new IEnumerable<string> CollectContentLines()
        {
            return new List<string>
            {
                Id,
                Type,
                ContentLineOne,
                ContentLineTwo
            };
        }
    }
}