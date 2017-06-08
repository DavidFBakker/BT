using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EMDB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace EMDB
{
    public static class DB
    {
        //public static string ConnectionString()
        //{
        //    var configuration = new ConfigurationBuilder()
        //        .AddJsonFile("appsettings.json")
        //        .AddEnvironmentVariables()
        //        .Build();

        //    var connection = configuration.GetConnectionString("DefaultConnection");
        //    return connection;
        //}

        //public static EMContext GetContext(bool withLogging = false)
        //{
            
        //    var configuration = new ConfigurationBuilder()
        //        .AddJsonFile("appsettings.json")                
        //        .Build();

        //    var connection = configuration.GetConnectionString("DefaultConnection");
        
        //    var db = new EMContext(connection);//optionsBuilder.Options);
          
        //    return db;
        //}
        
        public static DateTime StartDate(EMContext dbContext )
        {
            //if (dbContext == null)
            //    dbContext = Config.

            var ret = dbContext.Packets.Select(a => a.DT).First();
            return ret;
        }

        public static DateTime EndDate(EMContext dbContext)
        {
            //if (dbContext == null)
            //    dbContext = GetContext();

            var ret = dbContext.Packets.Select(a => a.DT).OrderByDescending(a => a).First();
            return ret;
        }      

        public static IEnumerable<Plot> GetPacketsQ(EMContext dbContext, string node, string channel,
            DateTime startDate, DateTime endDate, bool reverseSort=false)
        {
         //   var t = inputEnum.ToString();


            var chan = dbContext.Channels.First(a => a.Name == channel);


            var qstring = $"new(DT , {chan.Channel} as Value)";
            var qqq = $"Node = \"{node}\" AND DT >= \"{startDate}\" AND DT <= \"{endDate}\"";

            var q22 = dbContext.Packets.Where(qqq);
            if (reverseSort)
            {
                q22 = dbContext.Packets.Where(qqq).OrderByDescending(a=>a.DT);
            }

            var q = q22.Select(qstring).ToDynamicList().Select(a => new Plot { DT = a.DT, Value = a.Value });
            
            

            return q;
        }
        public static async Task<List<Plot>> GetPacketsAsync(EMContext dbContext)//,bool reverseSort = false)
        {            
            var res = await dbContext.Plots.FromSql(@"SELECT CAST(ROW_NUMBER()  over (order by name asc)AS INT) [ID],* FROM [dbo].[GetLatestPackets] ()").ToListAsync();

            return res;
        }

        public static async Task<List<Plot>> GetPlotsNoChannels(EMContext dbContext)//,bool reverseSort = false)
        {
            var res = await dbContext.Plots.FromSql(@"SELECT CAST(ROW_NUMBER()  over (order by name asc)AS INT) [ID],* FROM [dbo].[GetLatestPackets] () where Name not like 'Channel%'").ToListAsync();

            return res;
        }

        private static IEnumerable<string> _nodes;
        public static async Task<IEnumerable<string>> GetNodesAsync(EMContext dbContext)
        {
            if (_nodes == null)
            {              
                _nodes= await dbContext.Packets.Select(a => a.Node).Distinct().OrderBy(a => a).ToListAsync();
            }
            return _nodes;
        }

        private static Dictionary<string, IEnumerable<string>> _channels;

        public static async Task<IEnumerable<string>> GetChannelsAsync(string node,  EMContext dbContext)
        {
            if (_channels == null)
            {
                _channels=new Dictionary<string, IEnumerable<string>>();
            }

            if (!_channels.ContainsKey(node))
            {
            
                var names = dbContext.Channels.Where(a => a.Node == node)
                    .OrderBy(a => a.Node)
                    .ThenBy(a => a.ChannelType)
                    .ThenBy(a => a.Name)
                    .ThenBy(a => a.ChannelNumber)
                    .Select(a => a.Name);

                _channels[node] = await names.ToListAsync();
            }

            return _channels[node];
        }

    }
}