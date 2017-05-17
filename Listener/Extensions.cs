using EMDB;
using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;

namespace Listener
{
    public static class Extensions
    {
        public static Packet ToPacket(this string queryString)
        {
            var queryDictionary = QueryHelpers.ParseQuery(queryString);
            if (queryDictionary.ContainsKey("json"))
            {
                var ds = JsonConvert.DeserializeObject<Packet>(queryDictionary["json"]);
                if (ds == null)
                    return null;

                ds.Node = queryDictionary["node"];
                ds.V = ds.V * .1;


                return ds;
            }

            return null;
        }
    }
}