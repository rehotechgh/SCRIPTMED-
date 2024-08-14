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
    public class ANCHistoryController : Controller
    {

        //injection
        private readonly ALENGINEContext _db;

        public ANCHistoryController(ALENGINEContext db)
        {
            _db = db;
        } // GET: /<controller>/
        public IActionResult Index(string Searchstring)
        {
            IEnumerable<Central> objlist = _db.Centrals.Where(x => x.TUNIT == "ANC");


        ViewData["CurrentFilter"] = Searchstring;
            if (!String.IsNullOrEmpty(Searchstring))
            {
                objlist = objlist.Where(b => b.RegistrationNumber.Contains(Searchstring));


            }
            return View(objlist);
}
    }
}

