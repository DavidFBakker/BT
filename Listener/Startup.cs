using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using EMDB;
using EMDB.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Listener
{
    public class Startup
    {
        private static Dictionary<string, Packet> Packets;

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        private static string OS()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                return "Linux";

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                return "Windows";

            return "Who Knows";
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            Packets = new Dictionary<string, Packet>();


          //  var db = new DB();

            loggerFactory.AddConsole();
            var logger = loggerFactory.CreateLogger("Info");
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            logger.LogInformation($"SQL Connection: {DB.ConnectionString()}");
            logger.LogInformation($"OS: {OS()}");

            app.Run(async context =>
            {
                if (context.Request.QueryString.HasValue)
                {
                    var ds = context.Request.QueryString.Value.ToPacket();
                    if (ds != null)
                    {
                        if (!Packets.ContainsKey(ds.Node))
                        {
                            Packet res = null;

                            using (var dbContext = DB.GetContext())
                            {
                                res =
                                    dbContext.Packets.Where(a => a.Node == ds.Node )
                                        .OrderByDescending(b => b.DT).Take(1)
                                        .FirstOrDefault();

                                if (res != null && res.DT  >= DateTime.Now.AddMinutes(-10))
                                {
                                    Packets[ds.Node] = res;
                                    Packets[ds.Node].Add(ds);
                                }
                            }

                            if (res == null)
                            {
                                Packets[ds.Node] = ds;
                                Packets[ds.Node].Delta1 = ds.E1;
                                Packets[ds.Node].Delta2 = ds.E2;
                                Packets[ds.Node].Delta3 = ds.E3;
                                Packets[ds.Node].Delta4 = ds.E4;
                                Packets[ds.Node].Delta5 = ds.E5;
                                Packets[ds.Node].Delta6 = ds.E6;
                                Packets[ds.Node].Delta7 = ds.E7;
                                Packets[ds.Node].Delta8 = ds.E8;
                                Packets[ds.Node].Delta9 = ds.E9;
                                Packets[ds.Node].Delta10 = ds.E10;
                                Packets[ds.Node].Delta11 = ds.E11;
                                Packets[ds.Node].Delta12 = ds.E12;
                                Packets[ds.Node].Delta13 = ds.E13;
                                Packets[ds.Node].Delta14 = ds.E14;
                                Packets[ds.Node].Delta15 = ds.E15;
                                Packets[ds.Node].Delta16 = ds.E16;
                                Packets[ds.Node].Delta17 = ds.E17;
                                Packets[ds.Node].Delta18 = ds.E18;
                                Packets[ds.Node].Delta19 = ds.E19;
                                Packets[ds.Node].Delta20 = ds.E20;
                                Packets[ds.Node].Delta21 = ds.E21;
                                Packets[ds.Node].Delta22 = ds.E22;
                                Packets[ds.Node].Delta23 = ds.E23;
                                Packets[ds.Node].Delta24 = ds.E24;
                                Packets[ds.Node].Delta25 = ds.E25;
                                Packets[ds.Node].Delta26 = ds.E26;
                                Packets[ds.Node].Delta27 = ds.E27;
                                Packets[ds.Node].Delta28 = ds.E28;
                                Packets[ds.Node].Delta29 = ds.E29;
                                Packets[ds.Node].Delta30 = ds.E30;
                                Packets[ds.Node].Delta31 = ds.E31;
                                Packets[ds.Node].Delta32 = ds.E32;
                            }
                        }
                        else
                        {
                            Packets[ds.Node].Add(ds);
                            //Packets[ds.Node] = ds;
                        }

                        Packets[ds.Node].DT = DateTime.Now;

                      

                        //logger.LogInformation
                        logger.LogInformation(
                            $"Received packet from node {Packets[ds.Node].Node} @ {Packets[ds.Node].DT.ToLocalTime()}");
                        //Console.WriteLine($"{Packets[ds.Node].Wh2} {Packets[ds.Node].P2} {Packets[ds.Node].Delta2}");
                        //Console.WriteLine($"{Packets[ds.Node].Wh3} {Packets[ds.Node].P3} {Packets[ds.Node].Delta3}");
                        //Console.WriteLine($"{Packets[ds.Node].Wh4} {Packets[ds.Node].P4} {Packets[ds.Node].Delta4}");
                        //Console.WriteLine($"{Packets[ds.Node].Wh5} {Packets[ds.Node].P5} {Packets[ds.Node].Delta5}");
                        //Console.WriteLine($"{Packets[ds.Node].Wh6} {Packets[ds.Node].P6} {Packets[ds.Node].Delta6}");
                        //Console.WriteLine($"{Packets[ds.Node].Wh7} {Packets[ds.Node].P7} {Packets[ds.Node].Delta7}");
                        //Console.WriteLine($"{Packets[ds.Node].Wh8} {Packets[ds.Node].P8} {Packets[ds.Node].Delta8}");
                        //Console.WriteLine($"{Packets[ds.Node].Wh9} {Packets[ds.Node].P9} {Packets[ds.Node].Delta9}");
                        //Console.WriteLine($"{Packets[ds.Node].Wh10} {Packets[ds.Node].P10} {Packets[ds.Node].Delta10}");
                        //Console.WriteLine($"{Packets[ds.Node].Wh11} {Packets[ds.Node].P11} {Packets[ds.Node].Delta11}");
                        //Console.WriteLine($"{Packets[ds.Node].Wh12} {Packets[ds.Node].P12} {Packets[ds.Node].Delta12}");
                        //Console.WriteLine($"{Packets[ds.Node].Wh13} {Packets[ds.Node].P13} {Packets[ds.Node].Delta13}");
                        //Console.WriteLine($"{Packets[ds.Node].Wh14} {Packets[ds.Node].P14} {Packets[ds.Node].Delta14}");
                        //Console.WriteLine($"{Packets[ds.Node].Wh15} {Packets[ds.Node].P15} {Packets[ds.Node].Delta15}");
                        //Console.WriteLine($"{Packets[ds.Node].Wh16} {Packets[ds.Node].P16} {Packets[ds.Node].Delta16}");
                        //Console.WriteLine($"{Packets[ds.Node].Wh17} {Packets[ds.Node].P17} {Packets[ds.Node].Delta17}");
                        //Console.WriteLine($"{Packets[ds.Node].Wh18} {Packets[ds.Node].P18} {Packets[ds.Node].Delta18}");
                        //Console.WriteLine($"{Packets[ds.Node].Wh19} {Packets[ds.Node].P19} {Packets[ds.Node].Delta19}");
                        //Console.WriteLine($"{Packets[ds.Node].Wh20} {Packets[ds.Node].P20} {Packets[ds.Node].Delta20}");
                        //Console.WriteLine($"{Packets[ds.Node].Wh21} {Packets[ds.Node].P21} {Packets[ds.Node].Delta21}");
                        //Console.WriteLine($"{Packets[ds.Node].Wh22} {Packets[ds.Node].P22} {Packets[ds.Node].Delta22}");
                        //Console.WriteLine($"{Packets[ds.Node].Wh23} {Packets[ds.Node].P23} {Packets[ds.Node].Delta23}");
                        //Console.WriteLine($"{Packets[ds.Node].Wh24} {Packets[ds.Node].P24} {Packets[ds.Node].Delta24}");
                        //Console.WriteLine($"{Packets[ds.Node].Wh25} {Packets[ds.Node].P25} {Packets[ds.Node].Delta25}");
                        //Console.WriteLine($"{Packets[ds.Node].Wh26} {Packets[ds.Node].P26} {Packets[ds.Node].Delta26}");
                        //Console.WriteLine($"{Packets[ds.Node].Wh27} {Packets[ds.Node].P27} {Packets[ds.Node].Delta27}");
                        //Console.WriteLine($"{Packets[ds.Node].Wh28} {Packets[ds.Node].P28} {Packets[ds.Node].Delta28}");
                        //Console.WriteLine($"{Packets[ds.Node].Wh29} {Packets[ds.Node].P29} {Packets[ds.Node].Delta29}");
                        //Console.WriteLine($"{Packets[ds.Node].Wh30} {Packets[ds.Node].P30} {Packets[ds.Node].Delta30}");
                        //Console.WriteLine($"{Packets[ds.Node].Wh31} {Packets[ds.Node].P31} {Packets[ds.Node].Delta31}");
                        //Console.WriteLine($"{Packets[ds.Node].Wh32} {Packets[ds.Node].P32} {Packets[ds.Node].Delta32}");
                        //Console.WriteLine($"{ds.SecCounter} {ds.SC} {ds.X} {ds.V}");

                        try
                        {
                            using (var dbContext = DB.GetContext())
                            {
                                await dbContext.Packets.AddAsync(Packets[ds.Node]);
                                await dbContext.SaveChangesAsync();
                            }
                        }
                        catch (Exception ex)
                        {
                            logger.LogError("11",ex);
                            var aa = ex.Message;
                        }

                        await context.Response.WriteAsync("ok");
                    }
                }
            });
        }
    }
}