using ALENGINE.Data;
using ALENGINE.Models;
using ALENGINE.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ALENGINE.Controllers
{
    public class ViewClaimsController : Controller
    {

        //injection
        private readonly ALENGINEContext _db;

        public ViewClaimsController(ALENGINEContext db)
        {
            _db = db;
        }
        public IActionResult Index(int id)
        {
            // return View(obj);
            
            var showdatabyID = _db.Centrals.FirstOrDefault(m => m.Id == id);
            var vm = CentralViewModel.ViewInitData(showdatabyID);



            return View(vm);


        }
        [HttpPost]
        public IActionResult Index(Central obj)
        {
            // return View(obj);


         
            _db.Centrals.Update(obj);
            _db.SaveChanges();
            // return RedirectToAction("ServiceRequest", "GeneralUser");

            ViewBag.Message = "Calims Records Updated!";
           // ModelState.Clear();
            return View();


        }
    }
}
