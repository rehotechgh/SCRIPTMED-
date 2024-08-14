using ALENGINE.Data;
using ALENGINE.Models;
using Microsoft.AspNetCore.Mvc;

namespace ALENGINE.Controllers
{
    public class ClaimsController : Controller
    {

        //injection
        private readonly ALENGINEContext _db;

        public ClaimsController(ALENGINEContext db)
        {
            _db = db;
        }
        public IActionResult Index(string Searchstring)
        {
            DateTime currentDateTime = DateTime.Today;
             IEnumerable<Central> objlist = _db.Centrals.Where(m => m.DateCreated.Date >= currentDateTime).ToList();
           // IEnumerable<Central> objlist = _db.Centrals;
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
