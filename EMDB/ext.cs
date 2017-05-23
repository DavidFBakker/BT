using System;

namespace EMDB
{
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