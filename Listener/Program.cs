using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.CommandLineUtils;

namespace Listener
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var app = new CommandLineApplication(true) {Name = "Listener"};
            app.HelpOption("-?|-h|--help");
            
            var port = 8000;
         
            app.Command("port", config =>
            {
                config.Description = "Port to listen on";
                var portArg = config.Argument("[port number]", "The port number to listen on 2");

                config.OnExecute(() =>
                {
                    port = int.Parse(portArg.Value);
                    return 0;
                });

                config.Command("help", config2 =>
                {
                    config2.Description = "The port number to listen on";
                    config2.OnExecute(() =>
                    {
                        config.ShowHelp("config");
                        return 1;
                    });
                });
            });
            
           
           var result = app.Execute(args);
            if (result != 0)
            {
                Environment.Exit(result);
            }
         
           Console.WriteLine(result);
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseSetting("detailedErrors", "true")
                .UseUrls($"http://*:{port};")
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();
          
            host.Run();
        }
    }
}