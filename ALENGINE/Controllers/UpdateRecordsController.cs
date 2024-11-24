using ALENGINE.Data;
using ALENGINE.Models;
using ALENGINE.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ALENGINE.Controllers
{
    public class UpdateRecordsController : Controller
    {
        //injection
        private readonly ALENGINEContext _db;

        public UpdateRecordsController(ALENGINEContext db)
        {
            _db = db;
        }


        public IActionResult Index(int id)
        {
            // return View(obj);

            var showdatabyID = _db.PatientInformations.FirstOrDefault(m => m.PatientInformationId == id);
           // var vm = CentralViewModel.ViewInitData(showdatabyID);



            return View(showdatabyID);
        }

        [HttpPost]
        public IActionResult Index(PatientInformation obj)
        {

            _db.PatientInformations.Update(obj);
            _db.SaveChanges();
            // return RedirectToAction("ServiceRequest", "GeneralUser");

            ViewBag.Message = "Patient Records Updated!";
            ModelState.Clear();
            return View();
        }
    }
}
