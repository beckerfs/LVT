using LVT.Interfaces;
using LVT.Services.ObjectClasses;
using System.Linq;
using System.Text;

namespace LVT.Services
{
    class GoogleOrgChartBuilder : IGoogleOrgChartBuilder
    {
        public string BuildOrgChartDataString(Vision vision, string parentId = "")
        {
            var nodeString = string.Format(Properties.Resources.OrgChartNodeString, vision.Id, vision.Type, vision.ContentLineOne, parentId);
            var subnodesStrings = vision.Goals.Select(goal => BuildOrgChartDataString(goal, vision.Id));

            return $"[{nodeString}, {string.Join(" , ", subnodesStrings)}]";
        }

        private string BuildOrgChartDataString(Goal goal, string parentId)
        {
            var nodeString = string.Format(Properties.Resources.OrgChartNodeString, goal.Id, goal.Type, goal.ContentLineOne, parentId);
            var subnodesStrings = goal.Bets.Select(bet => BuildOrgChartDataString(bet, goal.Id));

            return $"{nodeString}, {string.Join(" , ", subnodesStrings)}";
        }

        private string BuildOrgChartDataString(Bet bet, string parentId)
        {
            var nodeString = string.Format(Properties.Resources.OrgChartNodeString, bet.Id, bet.Type, bet.ContentLineOne, parentId);
            var subnodesStrings = bet.Initiatives.Select(initiative => BuildOrgChartDataString(initiative, bet.Id));

            return $"{nodeString}, {string.Join(" , ", subnodesStrings)}";
        }

        private string BuildOrgChartDataString(Initiative initiative, string parentId)
        {
            var nodeString = string.Format(Properties.Resources.OrgChartNodeString, initiative.Id, initiative.Type, initiative.ContentLineOne, parentId);
            var measuresStrings = initiative.Measures.Select(measure => BuildOrgChartDataString(measure, initiative.Id));
            var epicsStrings = initiative.Epics.Select(epic => BuildOrgChartDataString(epic, initiative.Id));
            var subnodesStrings = measuresStrings.Concat(epicsStrings);

            return $"{nodeString}, {string.Join(" , ", subnodesStrings)}";
        }

        private string BuildOrgChartDataString(Measure measure, string parentId)
        {
            return string.Format(Properties.Resources.OrgChartMeasureString, measure.Id, measure.Type, measure.ContentLineOne, measure.ContentLineTwo, measure.ContentLineThree, measure.ContentLineFour, parentId);
        }

        private string BuildOrgChartDataString(Epic epic, string parentId)
        {
            return string.Format(Properties.Resources.OrgChartEpicString, epic.Id, epic.Type, epic.ContentLineOne, epic.ContentLineTwo, parentId);
        }
    }
}
