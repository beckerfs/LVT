using LVT.LVT.Interfaces;
using System.Collections.Generic;

namespace LVT.Services.ObjectClasses
{
    public class Measure : Node, INode
    {
        public Measure(string description, string deadline, string unit, string amount) : base(description)
        {
            ContentLineOne = description;
            ContentLineTwo = deadline;
            ContentLineThree = amount;
            ContentLineFour = unit;
        }

        public string ContentLineTwo { get; private set; }
        public string ContentLineThree { get; private set; }
        public string ContentLineFour { get; private set; }

        new public IEnumerable<string> CollectProperties()
        {
            return new List<string>
            {
                Id,
                Type,
                ContentLineOne,
                ContentLineTwo,
                ContentLineThree,
                ContentLineFour
            };
        }
    }
}