#region Using Directives

using System;
using System.Linq;
using System.Threading.Tasks;
using EMDB;
using EMDB.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;

#endregion

namespace Visualize.Controllers
{
    #region Using Directives

    #endregion

    /// <summary>
    ///     The grid controller.
    /// </summary>
    public class GridController : Controller
    {
        private readonly EMContext _context;

        public GridController(EMContext context)
        {
            _context = context;
        }


        public JsonResult ValidInputs(string node = "")
        {
            if (string.IsNullOrEmpty(node))
                node = Config.FirstNode;

            //var names = _context.EmToNames.Where(a => a.Node == node).Select(a => a.Name);

            return Json(DB.GetChannelsAsync(node,Config.DbContext).Result);
        }

        public JsonResult ValidZooms()
        {
            var validInputs = Enum.GetNames(typeof(ChartAxisBaseUnit)).OrderBy(a => a);
            return Json(validInputs);
        }

        public async Task<ActionResult> GridData([DataSourceRequest] DataSourceRequest request, string channel = "",
            DateTime? startDate = null, DateTime? endDate = null, string node = "")
        {
            //if (startDate == null)
            //    startDate = Config.StartDate;

            //if (endDate == null)
            //    endDate = Config.EndDate;

          
            //if (string.IsNullOrEmpty(node))
            //    node = Config.FirstNode;

            //if (string.IsNullOrEmpty(channel))
            //    channel = Config.FirstChannel;


         //   var res = DB.GetPacketsQ(_context, node, channel, (DateTime) startDate, (DateTime) endDate,true);
            var res = await DB.GetPacketsAsync(_context);
            var r1 = res.ToDataSourceResult(request);
            var r = Json(r1);
            return r;
        }

        public ActionResult GraphData(string channel = "", DateTime? startDate = null, DateTime? endDate = null,
            string node = "")
        {
            if (startDate == null)
                startDate = Config.StartDate;

            if (endDate == null)
                endDate = Config.EndDate;

            if (string.IsNullOrEmpty(node))
                node = Config.FirstNode;

            if (string.IsNullOrEmpty(channel))
                channel = Config.FirstChannel;


            var res = DB.GetPacketsQ(_context, node, channel, (DateTime) startDate, (DateTime) endDate);
//            var res = DB.GetPackets(_context);
  //          var j = res.ToList();

            var r = Json(res);
            return r;
        }

        public IActionResult ValidNodes()
        {
            return Json(DB.GetNodesAsync(_context).Result);
        }
    }
}