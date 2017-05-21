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

        public async Task<IActionResult> Graphs()
        {
            var model = await _context.Packets.Where(a=> a.Node=="Left Panel" && a.DT.Date==DateTime.Today.Date).OrderBy(a=>a.DT).ToListAsync();
            return View(model);

         //   return View();
        }

        public async Task<IActionResult> ListRead([DataSourceRequest] DataSourceRequest request)
        {
            IQueryable<Packet> packets = _context.Packets.Take(10);

            DataSourceResult result = await packets.ToDataSourceResultAsync(request);
            var j = Json(result);
            return j;
        }
    }
}
