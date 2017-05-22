using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EMDB;
using EMDB.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;

namespace Visualize
{
    public class PacketsController : Controller
    {
        private readonly EMContext _context;

        readonly List<string> _validInputs = new List<string>() {"Delta1",
            "Delta10",
            "Delta11",
            "Delta12",
            "Delta13",
            "Delta14",
            "Delta15",
            "Delta16",
            "Delta17",
            "Delta18",
            "Delta19",
            "Delta2",
            "Delta20",
            "Delta21",
            "Delta22",
            "Delta23",
            "Delta24",
            "Delta25",
            "Delta26",
            "Delta27",
            "Delta28",
            "Delta29",
            "Delta3",
            "Delta30",
            "Delta31",
            "Delta32",
            "Delta4",
            "Delta5",
            "Delta6",
            "Delta7",
            "Delta8",
            "Delta9",
            "E1",
            "E10",
            "E11",
            "E12",
            "E13",
            "E14",
            "E15",
            "E16",
            "E17",
            "E18",
            "E19",
            "E2",
            "E20",
            "E21",
            "E22",
            "E23",
            "E24",
            "E25",
            "E26",
            "E27",
            "E28",
            "E29",
            "E3",
            "E30",
            "E31",
            "E32",
            "E4",
            "E5",
            "E6",
            "E7",
            "E8",
            "E9",
            "P1",
            "P10",
            "P11",
            "P12",
            "P13",
            "P14",
            "P15",
            "P16",
            "P17",
            "P18",
            "P19",
            "P2",
            "P20",
            "P21",
            "P22",
            "P23",
            "P24",
            "P25",
            "P26",
            "P27",
            "P28",
            "P29",
            "P3",
            "P30",
            "P31",
            "P32",
            "P4",
            "P5",
            "P6",
            "P7",
            "P8",
            "P9",
            "SC",
            "W9",
            "V",
            "Wh1",
            "Wh10",
            "Wh11",
            "Wh12",
            "Wh13",
            "Wh14",
            "Wh15",
            "Wh16",
            "Wh17",
            "Wh18",
            "Wh19",
            "Wh2",
            "Wh20",
            "Wh21",
            "Wh22",
            "Wh23",
            "Wh24",
            "Wh25",
            "Wh26",
            "Wh27",
            "Wh28",
            "Wh29",
            "Wh3",
            "Wh30",
            "Wh31",
            "Wh32",
            "Wh4",
            "Wh5",
            "Wh6",
            "Wh7",
            "Wh8",
            "Wh9",
            "X",
            "DeltaSeconds",
            "W1",
            "W10",
            "W11",
            "W12",
            "W13",
            "W14",
            "W15",
            "W16",
            "W17",
            "W18",
            "W19",
            "W2",
            "W20",
            "W21",
            "W22",
            "W23",
            "W24",
            "W25",
            "W26",
            "W27",
            "W28",
            "W29",
            "W3",
            "W30",
            "W31",
            "W32",
            "W4",
            "W5",
            "W6",
            "W7",
            "W8"
        };

     
        public PacketsController(EMContext context)
        {
            _context = context;

           
        }

        // GET: Packets
        public async Task<IActionResult> Index()//[DataSourceRequest] DataSourceRequest request)
        {
            //IQueryable<Packet> packets = _context.Packets.Take(10);

            //DataSourceResult result = await packets.ToDataSourceResultAsync(request);
            //return Json(result);
            //return View();
            //var model = await _context.Packets.Take(10).ToListAsync

            //ViewBag.Packets = model;
            var model = await _context.Packets.Take(10).ToListAsync();
           // ViewBag.inputs = _validInputs;
            return View(model);
        }

        public async Task<IActionResult> ReadPacketsAsync([DataSourceRequest] DataSourceRequest request)
        {
            IQueryable<Packet> packets = _context.Packets.Take(10);

            DataSourceResult result = await packets.ToDataSourceResultAsync(request);
            return Json(result);

            //var model = await _context.Packets.Take(10).ToListAsync();
            //return View(model);
        }

        public JsonResult ReadPackets([DataSourceRequest] DataSourceRequest request)
        {
            IQueryable<Packet> packets = _context.Packets.Take(10);

            DataSourceResult result =  packets.ToList().ToDataSourceResult(request);
            return Json(result);

            //var model = await _context.Packets.Take(10).ToListAsync();
            //return View(model);
        }


        // GET: Packets/Details/5
        public async Task<IActionResult> Details(DateTime? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var packet = await _context.Packets
                .SingleOrDefaultAsync(m => m.DT == id);
            if (packet == null)
            {
                return NotFound();
            }

            return View(packet);
        }

        // GET: Packets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Packets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DT,Node,SC,DeltaSeconds,V,X,E1,P1,Wh1,Delta1,W1,E2,P2,Wh2,Delta2,W2,E3,P3,Wh3,Delta3,W3,E4,P4,Wh4,Delta4,W4,E5,P5,Wh5,Delta5,W5,E6,P6,Wh6,Delta6,W6,E7,P7,Wh7,Delta7,W7,E8,P8,Wh8,Delta8,W8,E9,P9,Wh9,Delta9,W9,E10,P10,Wh10,Delta10,W10,E11,P11,Wh11,Delta11,W11,E12,P12,Wh12,Delta12,W12,E13,P13,Wh13,Delta13,W13,E14,P14,Wh14,Delta14,W14,E15,P15,Wh15,Delta15,W15,E16,P16,Wh16,Delta16,W16,E17,P17,Wh17,Delta17,W17,E18,P18,Wh18,Delta18,W18,E19,P19,Wh19,Delta19,W19,E20,P20,Wh20,Delta20,W20,E21,P21,Wh21,Delta21,W21,E22,P22,Wh22,Delta22,W22,E23,P23,Wh23,Delta23,W23,E24,P24,Wh24,Delta24,W24,E25,P25,Wh25,Delta25,W25,E26,P26,Wh26,Delta26,W26,E27,P27,Wh27,Delta27,W27,E28,P28,Wh28,Delta28,W28,E29,P29,Wh29,Delta29,W29,E30,P30,Wh30,Delta30,W30,E31,P31,Wh31,Delta31,W31,E32,P32,Wh32,Delta32,W32")] Packet packet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(packet);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(packet);
        }

        // GET: Packets/Edit/5
        public async Task<IActionResult> Edit(DateTime? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var packet = await _context.Packets.SingleOrDefaultAsync(m => m.DT == id);
            if (packet == null)
            {
                return NotFound();
            }
            return View(packet);
        }

        // POST: Packets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(DateTime id, [Bind("DT,Node,SC,DeltaSeconds,V,X,E1,P1,Wh1,Delta1,W1,E2,P2,Wh2,Delta2,W2,E3,P3,Wh3,Delta3,W3,E4,P4,Wh4,Delta4,W4,E5,P5,Wh5,Delta5,W5,E6,P6,Wh6,Delta6,W6,E7,P7,Wh7,Delta7,W7,E8,P8,Wh8,Delta8,W8,E9,P9,Wh9,Delta9,W9,E10,P10,Wh10,Delta10,W10,E11,P11,Wh11,Delta11,W11,E12,P12,Wh12,Delta12,W12,E13,P13,Wh13,Delta13,W13,E14,P14,Wh14,Delta14,W14,E15,P15,Wh15,Delta15,W15,E16,P16,Wh16,Delta16,W16,E17,P17,Wh17,Delta17,W17,E18,P18,Wh18,Delta18,W18,E19,P19,Wh19,Delta19,W19,E20,P20,Wh20,Delta20,W20,E21,P21,Wh21,Delta21,W21,E22,P22,Wh22,Delta22,W22,E23,P23,Wh23,Delta23,W23,E24,P24,Wh24,Delta24,W24,E25,P25,Wh25,Delta25,W25,E26,P26,Wh26,Delta26,W26,E27,P27,Wh27,Delta27,W27,E28,P28,Wh28,Delta28,W28,E29,P29,Wh29,Delta29,W29,E30,P30,Wh30,Delta30,W30,E31,P31,Wh31,Delta31,W31,E32,P32,Wh32,Delta32,W32")] Packet packet)
        {
            if (id != packet.DT)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(packet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PacketExists(packet.DT))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(packet);
        }

        // GET: Packets/Delete/5
        public async Task<IActionResult> Delete(DateTime? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var packet = await _context.Packets
                .SingleOrDefaultAsync(m => m.DT == id);
            if (packet == null)
            {
                return NotFound();
            }

            return View(packet);
        }

        // POST: Packets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(DateTime id)
        {
            var packet = await _context.Packets.SingleOrDefaultAsync(m => m.DT == id);
            _context.Packets.Remove(packet);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool PacketExists(DateTime id)
        {
            return _context.Packets.Any(e => e.DT == id);
        }

        public IActionResult Graphs()
        {

            // var db = new EMDB.DB();

            //var interval = (60 / 5) * 15;

            //var model = DB.GetPackets(_context,interval);

            ////            var model = await _context.Packets.Where(a=> a.Node=="Left Panel" && a.DT.Date==DateTime.Today.Date).OrderBy(a=>a.DT).ToListAsync();


            //return View(model.Result);

            return View();
        }

        public async Task<IActionResult> ListRead([DataSourceRequest] DataSourceRequest request)
        {
            IQueryable<Packet> packets = _context.Packets.Take(10);

            DataSourceResult result = await packets.ToDataSourceResultAsync(request);
            var j = Json(result);
            return j;
        }

        public JsonResult ValidInputs()
        {
            return Json(_validInputs);
        }

        public async Task<IActionResult> GraphData(string selection)
        {
            var interval = (60 / 5) * 15;
        //    var db = new EMDB.DB();
            
            var result =  await DB.GetPackets(_context,interval);
            var model= result.ToList();
            
            //  var j = Json(result.Result);

            return View(model);
        }
    }
}
