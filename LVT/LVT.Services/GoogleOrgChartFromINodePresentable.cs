using LVT.Interfaces;
using System.Linq;
using System.Text;

namespace LVT.LVT.Services
{
    class GoogleOrgChartFromINodePresentable
    {        
        public string BuildOrgChartStringFromINodePresentable(INodePresentable presentable, string parentNodeId)
        {
            var nodeProperties = presentable.ContentLinesToDisplay.ToList();
            var nodeId = presentable.Id;
            var nodeHeader = nodeProperties[0];
            var contentLines = nodeProperties.Skip(1);
            var subnodes = presentable.Subnodes;

            //ContentLinesToDisplay.ToList()[0] - ContentLinesToDisplay.ToList().Skip(1)
            //pseudo code, need to think about the the strings and variables - save strings in resources?  
            var nodeString = new StringBuilder($"[{{ v:'")
                .Append(nodeId)
                .Append($"', f:'")
                .Append(nodeHeader) 
                .Append(string.Join("", contentLines.Select(line => $"<div style=\"font-style:italic\">{line}</div>")))
                .Append($"'}}, '")
                .Append(parentNodeId)
                .Append($"']");

            //var subnodeString = string.Join(",", subnodes.Select(node => BuildOrgChartStringFromINodePresentable(node, presentable.Id)));

            var subnodeString = new StringBuilder(string.Join(", ", subnodes.Select(node => BuildOrgChartStringFromINodePresentable(node, nodeId))));

            return nodeString.Append(subnodeString).ToString();
        }
    }
}
