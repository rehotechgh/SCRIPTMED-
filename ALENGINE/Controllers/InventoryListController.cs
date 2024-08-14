using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALENGINE.Data;
using ALENGINE.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ALENGINE.Controllers
{
    public class InventoryListController : Controller
    {
        //injection
        private readonly ALENGINEContext _db;

        public InventoryListController(ALENGINEContext db)
        {
            _db = db;
        }

        public IActionResult Index(string Searchstring)
        {
            IEnumerable<Inventory> objlist = _db.Inventories;


            ViewData["CurrentFilter"] = Searchstring;
            if (!String.IsNullOrEmpty(Searchstring))
            {
                objlist = objlist.Where(b => b.ItemName.Contains(Searchstring));


            }
            return View(objlist);
        }
    }
}

