using System;
using System.IO;
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
                Console.WriteLine(lvtObject);
                Console.WriteLine(vision);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message); ;
            }
        }
    }
}
