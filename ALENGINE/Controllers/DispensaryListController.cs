using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALENGINE.Data;
using ALENGINE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ALENGINE.Controllers
{
    public class DispensaryListController : Controller
    {

        //injection
        private readonly ALENGINEContext _db;

        public DispensaryListController(ALENGINEContext db)
        {
            _db = db;
        }

        // GET: /<controller>/
        public IActionResult Index(string Searchstring)
        {
            DateTime currentDateTime = DateTime.Today;
           IEnumerable<Central> objlist = _db.Centrals.Where(m => m.DateCreated.Date >= currentDateTime).ToList();
          //  IEnumerable<Consulting> objlist = _db.Consultings.Include(x => x.ANCHistories).Where(m => m.DateCreated.Date >= currentDateTime).ToList(); ;


            ViewData["CurrentFilter"] = Searchstring;
            if (!String.IsNullOrEmpty(Searchstring))
           {
               objlist = objlist.Where(b => b.RegistrationNumber.Contains(Searchstring));


           }
           return View(objlist);
        }
    }
}

