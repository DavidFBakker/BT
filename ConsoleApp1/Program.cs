using System;
using System.Linq;
using System.Runtime.InteropServices;
using EMDB;

namespace ConsoleApp1
{
    internal class Program
    {
          private static string OS()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                return "Linux";

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                return "Windows";

            return "Who Knows";
        }
        private static void Main(string[] args)
        {
            var incMins = 60;
            Console.WriteLine("Hello World!");
            Console.WriteLine($"SQL Connection: {DB.ConnectionString()}");
            Console.WriteLine($"OS: {OS()}");

         
            var res = DB.GetPacketsQ(DB.GetContext(true), incMins, "Left Panel",Constants.InputType.V).ToList();

            Console.WriteLine($"Found {res.Count} rows");
        }
    }

   
}