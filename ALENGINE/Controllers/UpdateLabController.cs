using ALENGINE.Data;
using ALENGINE.Models;
using ALENGINE.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace ALENGINE.Controllers
{
    public class UpdateLabController : Controller
    {

        //injection
        private readonly ALENGINEContext _db;

        public UpdateLabController(ALENGINEContext db)
        {
            _db = db;
        }
        public IActionResult Index(int id)
        {
            // return View(obj);

            var showdatabyID = _db.VitalInfos.FirstOrDefault(m => m.Id == id);
            var vm = ConsultingViewModel.ViewInitData(showdatabyID);
            return View(vm);
        }
       
        [HttpPost]
        public IActionResult Index([FromForm] ConsultingViewModel obj)
        {

            var serviceRequest = new Central
            {
                LabResult = obj.LabResult
            };


            _db.Centrals.Update(serviceRequest);
            _db.SaveChanges();
            // return RedirectToAction("ServiceRequest", "GeneralUser");

            ViewBag.Message = "Lab Records Updated!";
            ModelState.Clear();
            return View();
        }

    }
}
