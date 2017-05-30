using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EMDB.Models;
using Microsoft.EntityFrameworkCore;

namespace EMDB
{
    public static class UTIL
    {
        public static void CreateChannels(EMContext dbContext)
        {
            using (var db = dbContext)
            {
                var inputNames = db.InputNames.Where(a=>!a.Name.Equals("E") && !a.Name.Equals("P")) .ToList();
                var emtonames = db.EmToNames.ToList();
                var nodes = DB.GetNodesAsync(db).Result;

                db.Database.ExecuteSqlCommand("delete from em.dbo.channels");

                var channels = new List<Channels>();

                foreach (var node in nodes)
                {
                    foreach (var em in emtonames.Where(a=>a.Node==node))
                    {
                        channels.AddRange(inputNames.Select(input => new Channels
                        {
                            Node = node,
                            Channel =$"{input.Name}{em.Channel}",
                            Name = $"{em.Name} - {input.Name}",
                            ChannelNumber = Convert.ToInt32(em.Channel),
                            ChannelType=  input.Name 

                        }));
                    }
                }
                db.Channels.AddRange(channels);
                db.SaveChanges();
            }
        }
    }
}
