using System;
using System.Linq;
using EMDB;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Hello World!");
            var db = new DB();
            using (var dbContext = db.GetContext())
            {
                var res =
                    dbContext.Packets.ToList();

                foreach (var r in res)
                {
                    Console.WriteLine($"{r.Node} {r.E1}");
                }
            }


        }
    }
}