using ALENGINE.Data;
using ALENGINE.Models;
using Microsoft.AspNetCore.Mvc;

namespace ALENGINE.Controllers
{
    public class AddMedicineLIstController : Controller
    {


        //injection
        private readonly ALENGINEContext _db;

        public AddMedicineLIstController(ALENGINEContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index([FromForm] MedicineList obj)
        {
           try
           {
            _db.MedicineLists.Add(obj);
            _db.SaveChanges();
            ViewBag.Message = "Medicine Added Successfully!";
            ModelState.Clear();
       
           }
           catch (System.Exception)
           {
            
           ViewBag.Message = "Operation Unsuccessful! Try Again";
           }
     return View();

        }
    }
}
