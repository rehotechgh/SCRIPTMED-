using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALENGINE.Data;
using ALENGINE.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ALENGINE.Controllers
{
   // [Authorize]
    public class OPDController : Controller
    {
        //injection
        private readonly ALENGINEContext _db;

        public OPDController(ALENGINEContext db)
        {
            _db = db;
        }

        // GET: /<controller>/
        public IActionResult Index(string Searchstring)
        {
            DateTime currentDateTime = DateTime.Today;

            // IEnumerable<InitialPayment> objlist = _db.InitialPayments.Where(m=>m.DateCreated.Date == DateTime.Now.Date);
            IEnumerable<InitialPayment> objlist = _db.InitialPayments.Where(m => m.DateCreated.Date >= currentDateTime).ToList();
            // IEnumerable<InitialPayment> objlist = _db.InitialPayments;


            ViewData["CurrentFilter"] = Searchstring;
            if (!String.IsNullOrEmpty(Searchstring))
            {
                objlist = objlist.Where(b => b.RegistrationNumber.Contains(Searchstring));

           
            }
            return View(objlist);
        }
    }
}

