using ALENGINE.Data;
using ALENGINE.Models;
using ALENGINE.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ALENGINE.Controllers
{
    public class LabController : Controller
    {
        //injection
        private readonly ALENGINEContext _db;

        public LabController(ALENGINEContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {

            
            return View();
        }
        public IActionResult Labdisplay(int id)
        {
            // return View(obj);
            var showdatabyID = _db.PatientInformations.FirstOrDefault(m => m.PatientInformationId == id);
            var vm = LabViewModel.showlab(showdatabyID);



            return View(vm);
        }
        [HttpPost]
        public IActionResult LabRequest([FromForm] LabViewModel obj)
        {
            var serviceRequest = new LabRequest

            {

                RegistrationNumber = obj.RegistrationNumber,
                FacilityNo = obj.FacilityNo,
                PatientType = obj.PatientType,
                RequestingPhysician = obj.RequestingPhysician,
                RequestPreparedBy = obj.RequestPreparedBy,
                ClinicalDiagnoses = obj.ClinicalDiagnoses,
                LabRequestDetails = obj.LabRequestDetails


            };
            _db.LabRequests.Add(serviceRequest);
            _db.SaveChanges();
            // return RedirectToAction("ServiceRequest", "GeneralUser");

            ViewBag.Message = "Lab Request  Details Saved Successfully!";
            ModelState.Clear();
            return View();
        }

    }
}
