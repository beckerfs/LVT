using LVT.LVT.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LVT.Interfaces
{
    public interface INodePresentable
    {
        string Id { get; }
        string Type { get; }
        string ContentLineOne { get; }
        string ContentLineTwo { get; }
        string ContentLineThree { get; }
        string ContentLineFour { get; }

        IList<INodePresentable> SubnodesOne { get; }
        IList<INodePresentable> SubnodesTwo { get; }
    }
}
