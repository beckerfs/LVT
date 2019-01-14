using LVT.Services.ObjectClasses;

namespace LVT.Interfaces
{
    public interface IGoogleOrgChartBuilder
    {
        string BuildOrgChartDataString(Vision vision, string id);
    }
}

