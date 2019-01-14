using System;
using System.IO;
using System.Linq;
using LVT.Services;
using LVT.Services.ObjectClasses;
using Newtonsoft.Json;

namespace LVT
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               // StreamReader stream = File.OpenText(args[0]);
                StreamReader stream = File.OpenText(@"C:\temp\VisionGoal.json");
                JsonSerializer serializer = new JsonSerializer();
                var lvtObject = (LeanValueTree)serializer.Deserialize(stream, typeof(LeanValueTree));
                var vision = lvtObject.Vision;
                Console.WriteLine(vision.Type);

                var converter = new VisionToNodePresentableConverter();
                Console.WriteLine(converter.GetType().Name);

                var builder = new GoogleOrgChartBuilder();

                var googleString = builder.BuildOrgChartDataString(vision, "");
                Console.WriteLine(googleString);
                //var persentable = converter.ConvertToNodePresentable(vision);
                //Console.WriteLine(persentable.GetType().Name);

                //var contentLines = persentable.ContentLinesToDisplay;
                //var subnodes = persentable.Subnodes.ToList().Count;
                //Console.WriteLine(subnodes);
                //foreach (var line in contentLines)
                //{
                //    Console.WriteLine(line);
                //}
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message); ;
            }
        }
    }
}
