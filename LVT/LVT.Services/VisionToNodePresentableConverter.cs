using LVT.Interfaces;
using LVT.Services.ObjectClasses;
using System.Collections.Generic;
using System.Linq;

namespace LVT.Services
{
    class VisionToNodePresentableConverter : IVisionToINodePresentableConverter
    {
        public INodePresentable ConvertToINodePresentable(Vision vision)
        {
            //this better or preferably more explicit as with epic/measure?  
            var contentLinesToDisplay = vision.CollectProperties();
            var subnodes = vision.Goals.Select(goal => ConvertToINodePresentable(goal));

            return new NodePresentable(vision.Id, contentLinesToDisplay, subnodes);
        }

        
        public INodePresentable ConvertToINodePresentable(Goal goal)
        {
            var contentLinesToDisplay = goal.CollectProperties();
            var subnodes = goal.Bets.Select(bet => ConvertToINodePresentable(bet));

            return new NodePresentable(goal.Id, contentLinesToDisplay, subnodes);
        }

      
        private INodePresentable ConvertToINodePresentable(Bet bet)
        {
            var contentLinesToDisplay = bet.CollectProperties();
            var subnodes = bet.Initiatives.Select(initiative => ConvertToINodePresentable(initiative));

            return new NodePresentable(bet.Id, contentLinesToDisplay, subnodes);
        }

        private INodePresentable ConvertToINodePresentable(Initiative initiative)
        {
            var contentLinesToDisplay = initiative.CollectProperties();
            var subnodes = initiative.Measures.Select(measure => ConvertToNodePresentable(measure)).Concat(initiative.Epics.Select(epic => ConvertToINodePresentable(epic)));
        
            return new NodePresentable(initiative.Id, contentLinesToDisplay, subnodes);
        }
              
        private INodePresentable ConvertToNodePresentable(Measure measure)
        {
            //var contentLinesToDisplay = new List<string>
            //{
            //    measure.Type,
            //    measure.ContentLineOne,
            //    measure.ContentLineTwo,
            //    measure.ContentLineThree,
            //    measure.ContentLineFour
            //};
            var contentLinesToDisplay = measure.CollectProperties();
            var subnodes = new List<INodePresentable>();

            return new NodePresentable(measure.Id, contentLinesToDisplay, subnodes);
        }

        private INodePresentable ConvertToINodePresentable(Epic epic)
        {
            //var contentLinesToDisplay = new List<string>
            //{
            //    epic.Type,
            //    epic.ContentLineOne,
            //    epic.ContentLineTwo
            //};
            var contentLinesToDisplay = epic.CollectProperties();
            var subnodes = new List<INodePresentable>();

            return new NodePresentable(epic.Id, contentLinesToDisplay, subnodes);
        }
    }
}