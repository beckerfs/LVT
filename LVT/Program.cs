﻿using System;
using System.IO;
using LVT.Services;
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
                var visionObject = (Vision)serializer.Deserialize(stream, typeof(Vision));
                Console.WriteLine(visionObject.ToString());
                Console.WriteLine(visionObject.Type);
                Console.WriteLine(visionObject.Id);
                Console.WriteLine(visionObject.ContentLineOne);
                Console.WriteLine(visionObject.Goals[0].Id);
                Console.WriteLine(visionObject.Goals[0].Type);
                Console.WriteLine(visionObject.Goals[0].ContentLineOne);
                Console.WriteLine(visionObject.FirstGoalAsINodePresentable().Id);
                Console.WriteLine(visionObject.FirstGoalAsINodePresentable().Type);
                Console.WriteLine(visionObject.FirstGoalAsINodePresentable().ContentLineOne);
                Console.WriteLine(visionObject.SubnodesOne[0].ContentLineOne);


            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message); ;
            }
        }
    }
}