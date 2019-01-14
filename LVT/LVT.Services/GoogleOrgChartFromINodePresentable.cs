using LVT.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LVT.LVT.Services
{
    class GoogleOrgChartFromINodePresentable
    {
        //WIP, to use with INodePresentable instead of object classes:
        //public string BuildOrgChartStringFromINodePresentable(INodePresentable presentable, string parentId)
        //{
        //    //pseudo code, need to think about the the strings and variables - save strings in resources?  
        //    var nodeString = new StringBuilder("v: ")
        //        .Append(presentable.Id)
        //        .Append(", f: ")
        //        .Append(presentable.ContentLinesToDisplay.ToList()[0])
        //        .Append(string.Join(" ", presentable.ContentLinesToDisplay.ToList().Skip(1)
        //            .Select(content => "div: " + content + "/div")))
        //        .Append(", pid:")
        //        .Append(parentId)
        //        .Append(" end");
        //    var subnodeString = string.Join(" ", presentable.Subnodes.Select(node => BuildOrgChartStringFromINodePresentable(node, presentable.Id)));

        //    return nodeString.Append(subnodeString).ToString();
        //}
    }
}
