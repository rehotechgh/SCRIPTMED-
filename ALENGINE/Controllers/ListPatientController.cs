
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ALENGINE.Data;
using ALENGINE.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public IActionResult Index()
        {
            IEnumerable<PatientInformation> objlist = _db.PatientInformations;


            return View(objlist);
        }
        public IActionResult Details(string id) { 

            var rs = _db.PatientInformations.Include(x => x.Centrals).FirstOrDefault(m => m.RegistrationNumber == id);

            ViewBag.P = rs;

            return View(rs);
        
        }
      
    }
}

