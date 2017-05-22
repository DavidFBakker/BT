using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
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

        public static string ConnectionString()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .Build();

            var connection = configuration.GetConnectionString("DefaultConnection");
            return connection;
        }
        public static EMContext GetContext(bool withLogging=false)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .Build();

            var connection = configuration.GetConnectionString("DefaultConnection");
            
            var optionsBuilder = new DbContextOptionsBuilder<EMContext>();
            optionsBuilder.UseSqlServer(connection);
            var db = new EMContext(optionsBuilder.Options);
            if (withLogging)
            {
                var serviceProvider = db.GetInfrastructure<IServiceProvider>();
                var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
                loggerFactory.AddProvider(new MyLoggerProvider());
            }
            return db;
        }

        public static async Task<IEnumerable<Packet>> GetPackets( int minuteSpan, bool log=false)
        {            
            return await GetPackets(GetContext(log), minuteSpan);
        }

       

        public static async Task<IEnumerable<Packet>> GetPackets(EMContext dbContext, int minuteSpan)
        {
            IEnumerable<Packet> ret;
            //   var db = new DB();
            //using (var dbContext = db.GetContext(true))
            //{
            var q = dbContext.Packets.GroupBy(g => g.DT.RoundToNearestInterval(TimeSpan.FromMinutes(minuteSpan)),
                    i => i)
                .Select(n => new Packet
                {
                    DT = n.Key,
                    Delta1 = n.Average(a => a.Delta1),
                    Delta10 = n.Average(a => a.Delta10),
                    Delta11 = n.Average(a => a.Delta11),
                    Delta12 = n.Average(a => a.Delta12),
                    Delta13 = n.Average(a => a.Delta13),
                    Delta14 = n.Average(a => a.Delta14),
                    Delta15 = n.Average(a => a.Delta15),
                    Delta16 = n.Average(a => a.Delta16),
                    Delta17 = n.Average(a => a.Delta17),
                    Delta18 = n.Average(a => a.Delta18),
                    Delta19 = n.Average(a => a.Delta19),
                    Delta2 = n.Average(a => a.Delta2),
                    Delta20 = n.Average(a => a.Delta20),
                    Delta21 = n.Average(a => a.Delta21),
                    Delta22 = n.Average(a => a.Delta22),
                    Delta23 = n.Average(a => a.Delta23),
                    Delta24 = n.Average(a => a.Delta24),
                    Delta25 = n.Average(a => a.Delta25),
                    Delta26 = n.Average(a => a.Delta26),
                    Delta27 = n.Average(a => a.Delta27),
                    Delta28 = n.Average(a => a.Delta28),
                    Delta29 = n.Average(a => a.Delta29),
                    Delta3 = n.Average(a => a.Delta3),
                    Delta30 = n.Average(a => a.Delta30),
                    Delta31 = n.Average(a => a.Delta31),
                    Delta32 = n.Average(a => a.Delta32),
                    Delta4 = n.Average(a => a.Delta4),
                    Delta5 = n.Average(a => a.Delta5),
                    Delta6 = n.Average(a => a.Delta6),
                    Delta7 = n.Average(a => a.Delta7),
                    Delta8 = n.Average(a => a.Delta8),
                    Delta9 = n.Average(a => a.Delta9),
                    E1 = n.Average(a => a.E1),
                    E10 = n.Average(a => a.E10),
                    E11 = n.Average(a => a.E11),
                    E12 = n.Average(a => a.E12),
                    E13 = n.Average(a => a.E13),
                    E14 = n.Average(a => a.E14),
                    E15 = n.Average(a => a.E15),
                    E16 = n.Average(a => a.E16),
                    E17 = n.Average(a => a.E17),
                    E18 = n.Average(a => a.E18),
                    E19 = n.Average(a => a.E19),
                    E2 = n.Average(a => a.E2),
                    E20 = n.Average(a => a.E20),
                    E21 = n.Average(a => a.E21),
                    E22 = n.Average(a => a.E22),
                    E23 = n.Average(a => a.E23),
                    E24 = n.Average(a => a.E24),
                    E25 = n.Average(a => a.E25),
                    E26 = n.Average(a => a.E26),
                    E27 = n.Average(a => a.E27),
                    E28 = n.Average(a => a.E28),
                    E29 = n.Average(a => a.E29),
                    E3 = n.Average(a => a.E3),
                    E30 = n.Average(a => a.E30),
                    E31 = n.Average(a => a.E31),
                    E32 = n.Average(a => a.E32),
                    E4 = n.Average(a => a.E4),
                    E5 = n.Average(a => a.E5),
                    E6 = n.Average(a => a.E6),
                    E7 = n.Average(a => a.E7),
                    E8 = n.Average(a => a.E8),
                    E9 = n.Average(a => a.E9),
                    P1 = n.Average(a => a.P1),
                    P10 = n.Average(a => a.P10),
                    P11 = n.Average(a => a.P11),
                    P12 = n.Average(a => a.P12),
                    P13 = n.Average(a => a.P13),
                    P14 = n.Average(a => a.P14),
                    P15 = n.Average(a => a.P15),
                    P16 = n.Average(a => a.P16),
                    P17 = n.Average(a => a.P17),
                    P18 = n.Average(a => a.P18),
                    P19 = n.Average(a => a.P19),
                    P2 = n.Average(a => a.P2),
                    P20 = n.Average(a => a.P20),
                    P21 = n.Average(a => a.P21),
                    P22 = n.Average(a => a.P22),
                    P23 = n.Average(a => a.P23),
                    P24 = n.Average(a => a.P24),
                    P25 = n.Average(a => a.P25),
                    P26 = n.Average(a => a.P26),
                    P27 = n.Average(a => a.P27),
                    P28 = n.Average(a => a.P28),
                    P29 = n.Average(a => a.P29),
                    P3 = n.Average(a => a.P3),
                    P30 = n.Average(a => a.P30),
                    P31 = n.Average(a => a.P31),
                    P32 = n.Average(a => a.P32),
                    P4 = n.Average(a => a.P4),
                    P5 = n.Average(a => a.P5),
                    P6 = n.Average(a => a.P6),
                    P7 = n.Average(a => a.P7),
                    P8 = n.Average(a => a.P8),
                    P9 = n.Average(a => a.P9),
                    SC = n.Average(a => a.SC),
                    W9 = n.Average(a => a.W9),
                    V = n.Average(a => a.V),
                    Wh1 = n.Average(a => a.Wh1),
                    Wh10 = n.Average(a => a.Wh10),
                    Wh11 = n.Average(a => a.Wh11),
                    Wh12 = n.Average(a => a.Wh12),
                    Wh13 = n.Average(a => a.Wh13),
                    Wh14 = n.Average(a => a.Wh14),
                    Wh15 = n.Average(a => a.Wh15),
                    Wh16 = n.Average(a => a.Wh16),
                    Wh17 = n.Average(a => a.Wh17),
                    Wh18 = n.Average(a => a.Wh18),
                    Wh19 = n.Average(a => a.Wh19),
                    Wh2 = n.Average(a => a.Wh2),
                    Wh20 = n.Average(a => a.Wh20),
                    Wh21 = n.Average(a => a.Wh21),
                    Wh22 = n.Average(a => a.Wh22),
                    Wh23 = n.Average(a => a.Wh23),
                    Wh24 = n.Average(a => a.Wh24),
                    Wh25 = n.Average(a => a.Wh25),
                    Wh26 = n.Average(a => a.Wh26),
                    Wh27 = n.Average(a => a.Wh27),
                    Wh28 = n.Average(a => a.Wh28),
                    Wh29 = n.Average(a => a.Wh29),
                    Wh3 = n.Average(a => a.Wh3),
                    Wh30 = n.Average(a => a.Wh30),
                    Wh31 = n.Average(a => a.Wh31),
                    Wh32 = n.Average(a => a.Wh32),
                    Wh4 = n.Average(a => a.Wh4),
                    Wh5 = n.Average(a => a.Wh5),
                    Wh6 = n.Average(a => a.Wh6),
                    Wh7 = n.Average(a => a.Wh7),
                    Wh8 = n.Average(a => a.Wh8),
                    Wh9 = n.Average(a => a.Wh9),
                    X = n.Average(a => a.X),
                    DeltaSeconds = n.Average(a => a.DeltaSeconds),
                    W1 = n.Average(a => a.W1),
                    W10 = n.Average(a => a.W10),
                    W11 = n.Average(a => a.W11),
                    W12 = n.Average(a => a.W12),
                    W13 = n.Average(a => a.W13),
                    W14 = n.Average(a => a.W14),
                    W15 = n.Average(a => a.W15),
                    W16 = n.Average(a => a.W16),
                    W17 = n.Average(a => a.W17),
                    W18 = n.Average(a => a.W18),
                    W19 = n.Average(a => a.W19),
                    W2 = n.Average(a => a.W2),
                    W20 = n.Average(a => a.W20),
                    W21 = n.Average(a => a.W21),
                    W22 = n.Average(a => a.W22),
                    W23 = n.Average(a => a.W23),
                    W24 = n.Average(a => a.W24),
                    W25 = n.Average(a => a.W25),
                    W26 = n.Average(a => a.W26),
                    W27 = n.Average(a => a.W27),
                    W28 = n.Average(a => a.W28),
                    W29 = n.Average(a => a.W29),
                    W3 = n.Average(a => a.W3),
                    W30 = n.Average(a => a.W30),
                    W31 = n.Average(a => a.W31),
                    W32 = n.Average(a => a.W32),
                    W4 = n.Average(a => a.W4),
                    W5 = n.Average(a => a.W5),
                    W6 = n.Average(a => a.W6),
                    W7 = n.Average(a => a.W7),
                    W8 = n.Average(a => a.W8)


                });

            //var param = Expression.Parameter(typeof(int), "p");
            //var exp = Expression.Lambda<Func<int, bool>>(
            //    Expression.Equal(
            //        Expression.Property(param, "Name"),
            //        Expression.Constant("Bob")
            //    ),
            //    param
            //);
            

            ret = await q.ToListAsync();
            //}
            return ret;
            //}
        }
    }


    internal static class ext
    {
        //public static long ToUnixTime(this DateTime date)
        //{
        //    var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        //    return Convert.ToInt64((date - epoch).TotalSeconds);
        //}

        public static DateTime RoundToNearestInterval(this DateTime dt, TimeSpan d)
        {
            var f = 0;
            var m = (double) (dt.Ticks % d.Ticks) / d.Ticks;
            if (m >= 0.5)
                f = 1;
            return new DateTime((dt.Ticks / d.Ticks + f) * d.Ticks);
        }

    }
}