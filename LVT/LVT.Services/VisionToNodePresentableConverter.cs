using LVT.Interfaces;
using LVT.Services.ObjectClasses;
using System.Collections.Generic;
using System.Linq;

namespace LVT.Services
{
    class VisionToNodePresentableConverter : IVisionToINodePresentableConverter
    {       
        public INodePresentable ConvertToNodePresentable(Vision vision)
        {
            //this better or preferably more explicit as with goals etc?  
            var contentLinesToDisplay = vision.CollectProperties();

            var subnodes = vision.Goals.Select(goal => ConvertToNodePresentable(goal));
            return new NodePresentable(vision.Id, contentLinesToDisplay, subnodes);
        }

        
        public INodePresentable ConvertToNodePresentable(Goal goal)
        {
            var contentLinesToDisplay = new List<string>
            {
                goal.Type,
                goal.ContentLineOne
            };
            var subnodes = goal.Bets.Select(bet => ConvertToNodePresentable(bet));
            return new NodePresentable(goal.Id, contentLinesToDisplay, subnodes);
        }

        private INodePresentable ConvertToNodePresentable(Bet bet)
        {
            var contentLinesToDisplay = new List<string>
            {
                bet.Type,
                bet.ContentLineOne
            };
            var subnodes = bet.Initiatives.Select(initiative => ConvertToNodePresentable(initiative));
            return new NodePresentable(bet.Id, contentLinesToDisplay, subnodes);
        }

        private INodePresentable ConvertToNodePresentable(Initiative initiative)
        {
            var contentLinesToDisplay = new List<string>
            {
                initiative.Type,
                initiative.ContentLineOne
            };
            var subnodes = initiative.Measures.Select(measure => ConvertToNodePresentable(measure)).Concat(initiative.Epics.Select(epic => ConvertToNodePresentable(epic)));
        
            return new NodePresentable(initiative.Id, contentLinesToDisplay, subnodes);
        }
              
        private INodePresentable ConvertToNodePresentable(Measure measure)
        {
            var contentLinesToDisplay = new List<string>
            {
                measure.Type,
                measure.ContentLineOne,
                measure.ContentLineTwo,
                measure.ContentLineThree,
                measure.ContentLineFour
            };
            var subnodes = new List<INodePresentable>();
            return new NodePresentable(measure.Id, contentLinesToDisplay, subnodes);
        }

        private INodePresentable ConvertToNodePresentable(Epic epic)
        {
            var contentLinesToDisplay = new List<string>
            {
                epic.Type,
                epic.ContentLineOne,
                epic.ContentLineTwo
            };
            var subnodes = new List<INodePresentable>();
            return new NodePresentable(epic.Id, contentLinesToDisplay, subnodes);
        }
    }
}