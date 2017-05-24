#region Using Directives

using System;
using System.Linq;
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

     
        public JsonResult ValidInputs()
        {
            return Json(Constants.ValidInputs);
        }

        public JsonResult ValidZooms()
        {
                var validInputs = Enum.GetNames(typeof(ChartAxisBaseUnit)).OrderBy(a=>a );
            return Json(validInputs);//new string[6] {"Years", "Months", "Weeks", "Day", "Hours", "Minutes"});
        }

        public ActionResult GridData([DataSourceRequest] DataSourceRequest request, string selection = "", DateTime? startDate=null, DateTime? endDate = null)
        {
            if (startDate == null)
                startDate = Config.StartDate;

            if (endDate == null)
                endDate = Config.EndDate;

            if (String.IsNullOrEmpty(selection))
            {
                selection = Constants.ValidInputs[0];
            }

            //var interval = 60 / 5 * 15;
            //var res = DB.GetPacketsQ(_context, interval, "Left Panel", selection.ToInputType(), 6);

            
            var res = DB.GetPacketsQ(_context, "Left Panel", selection.ToInputType(), (DateTime)startDate, (DateTime)endDate);

            var r1 = res.ToDataSourceResult(request);
            var r = Json(r1);
            return r;
        }

        public ActionResult GraphData(string selection = "", DateTime? startDate = null, DateTime? endDate = null)
        {
            if (startDate == null)
                startDate = Config.StartDate;

            if (endDate == null)
                endDate = Config.EndDate;

            if (String.IsNullOrEmpty(selection))
            {
                selection = Constants.ValidInputs[0];
            }

            var interval = 60 / 5 * 15;

            //var res = DB.GetPacketsQ(_context, interval, "Left Panel", selection.ToInputType(), 6); //.ToList();
            var res = DB.GetPacketsQ(_context, "Left Panel", selection.ToInputType(), (DateTime)startDate, (DateTime)endDate);
            var r = Json(res);
            return r;
        }
    }
}