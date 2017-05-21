using System;
using System.Linq;
using EMDB;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var incMins = 60;
            Console.WriteLine("Hello World!");
           var db = new EMDB.DB();

            db.GetPackets(incMins);
        }
    }

   
}