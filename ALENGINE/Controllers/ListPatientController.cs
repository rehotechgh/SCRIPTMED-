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
    public class ListPatientController : Controller
    {
        //injection
        private readonly ALENGINEContext _db;

        public ListPatientController(ALENGINEContext db)
        {
            _db = db;
        }

        //[Authorize]
        public IActionResult Index(string Searchstring)
        {
            IEnumerable<PatientInformation> objlist = _db.PatientInformations;


           ViewData["CurrentFilter"] = Searchstring;
         if (!String.IsNullOrEmpty(Searchstring))
          {
                objlist = objlist.Where(b => b.RegistrationNumber.Contains(Searchstring));


            }

            //IEnumerable<Registration> objlist = _db.Registration;
          //ViewBag.DatagGrid = objlist;
            return View(objlist);
        }
      
    }
}

