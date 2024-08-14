using System;
using System.Collections.Generic;
using System.Composition;
using System.Linq;
using System.Threading.Tasks;
using ALENGINE.Data;
using ALENGINE.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ALENGINE.Controllers
{
    public class DispensaryReportController : Controller
    {

        //injection
        private readonly ALENGINEContext _db;

        public DispensaryReportController(ALENGINEContext db)
        {
            _db = db;
        }
        // GET: /<controller>/
        public IActionResult Index(string Searchstring)
        {
           
            IEnumerable<InventoryTransaction> objlist = _db.InventoryTransactions;
            double v = objlist.Sum(x => x.SalesAmount);
            ViewBag.Message = v;
          


            ViewData["CurrentFilter"] = Searchstring;
            if (!String.IsNullOrEmpty(Searchstring))
            {
                objlist = objlist.Where(b => b.ItemName.Contains(Searchstring));


            }
            return View(objlist);
        }
    }
}

