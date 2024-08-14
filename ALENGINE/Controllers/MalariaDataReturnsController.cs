using ALENGINE.Data;
using ALENGINE.Models;
using Microsoft.AspNetCore.Mvc;

namespace ALENGINE.Controllers
{
    public class MalariaDataReturnsController : Controller
    {
        //injection
        private readonly ALENGINEContext _db;

        public MalariaDataReturnsController(ALENGINEContext db)
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
            ViewBag.History = objlist;

            return View();
        }
    }
}

