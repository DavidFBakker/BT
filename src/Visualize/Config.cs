#region Using Directives

using System;
using System.Linq;
using EMDB;
using EMDB.Models;

#endregion

namespace Visualize
{
    public static class Config
    {
        public static DateTime MinDate;
        public static DateTime StartDate;
        public static DateTime EndDate;
        public static string FirstNode;
        public static string FirstChannel;
        public static EMContext DbContext;

        public static void Startup(EMContext dbContext)
        {
            DbContext = dbContext;

            MinDate = DB.StartDate(dbContext);
            StartDate = DB.EndDate(dbContext).AddDays(-1);
            EndDate = DB.EndDate(dbContext);
            FirstNode = DB.GetNodesAsync(dbContext).Result.First();
            FirstChannel = DB.GetChannelsAsync(FirstNode, dbContext).Result.First();
        }
    }
}