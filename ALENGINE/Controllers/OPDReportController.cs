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
    [Authorize]
    public class OPDReportController : Controller
    {
        //injection
        private readonly ALENGINEContext _db;

        public OPDReportController(ALENGINEContext db)
        {
            _db = db;
        }

        // GET: /<controller>/
        public IActionResult Index(string Searchstring, DateTime startDateTime, DateTime endDateTime)
        {
            startDateTime = DateTime.Today;
            endDateTime = DateTime.Today;

            

            IEnumerable<VitalInfo> objlist = _db.VitalInfos;


            ViewData["CurrentFilter"] = Searchstring;
            ViewData["startDateTime"] = startDateTime;
            ViewData["endDateTime"] = endDateTime;
            if (!String.IsNullOrEmpty(Searchstring))
            {
                objlist = objlist.Where(b => b.RegistrationNumber.Contains(Searchstring)).Where(b=>b.DateCreated >= startDateTime && b.DateCreated <= endDateTime).ToList();


            }
            ViewBag.OPD = objlist;
            totalrecords();
            return View(objlist);
           


        }
        [Authorize]
        private void totalrecords()
        {

            var totalrecords = _db.VitalInfos.Count();
            ViewBag.totalrecords = totalrecords;
        }
    }
}

