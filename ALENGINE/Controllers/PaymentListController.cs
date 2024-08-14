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
    public class PaymentListController : Controller
    {
        //injection
        private readonly ALENGINEContext _db;

        public PaymentListController(ALENGINEContext db)
        {
            _db = db;
        }

        // GET: /<controller>/
        public IActionResult Index(string Searchstring)
        {
            IEnumerable<InitialPayment> objlist = _db.InitialPayments;

           ////  if (!String.IsNullOrEmpty(Searchstring))
        //  {
            //    objlist = objlist.Where(b => b.PID.Contains(Searchstring));


           // }



            // IEnumerable<Registration> objlist = _db.Registration;

            return View(objlist);
        }
    }
}

