using System;
using System.Collections.Generic;
using System.Text;

namespace LVT.Interfaces
{
    interface IGoogleChartBuilder
    {
        string BuildOrgChartDataString(INodePresentable node);
    }
}

