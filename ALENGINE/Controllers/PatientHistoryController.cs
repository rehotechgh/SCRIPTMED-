using ALENGINE.Data;
using ALENGINE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ALENGINE.Controllers
{
    public class PatientHistoryController : Controller
    {
        //injection
        private readonly ALENGINEContext _db;

        public PatientHistoryController(ALENGINEContext db)
        {
            _db = db;
        }
        public IActionResult Index(string Searchstring)
        {
            IEnumerable<Central> objlist = _db.Centrals;


            ViewData["CurrentFilter"] = Searchstring;
            if (!String.IsNullOrEmpty(Searchstring))
            {
                objlist = objlist.Where(b => b.RegistrationNumber.Contains(Searchstring));


            }

            // IEnumerable<Registration> objlist = _db.Registration;
            ViewBag.History=objlist;

            return View();
        }
    }
}
