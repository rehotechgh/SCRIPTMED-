using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALENGINE.Data;

using ALENGINE.Models;
using ALENGINE.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ALENGINE.Controllers
{
    public class AddVitalsController : Controller
    {
        //injection
        private readonly ALENGINEContext _db;

        public AddVitalsController(ALENGINEContext db)
        {
            _db = db;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Viewvitals(int id)
        {
            // return View(obj);
            var showdatabyID = _db.InitialPayments.FirstOrDefault(m => m.Id == id);
            var vm = VitalInfoViewModel.ViewInitData(showdatabyID);



            return View(vm);
        }
        [HttpPost]
        public IActionResult Viewvitals([FromForm] VitalInfoViewModel obj)
        {
            var serviceRequest = new VitalInfo

            {
                RegistrationNumber = obj.RegistrationNumber,
                Surname = obj.Surname,
                OtherNames = obj.OtherNames,
                Weight = obj.Weight,
                BloodGroup = obj.BloodGroup,
                BloodPressure = obj.BloodPressure,
                Height = obj.Height,
                Condition = obj.Condition,
                Temperature = obj.Temperature,
                Pulse = obj.Pulse,
                SP02 = obj.SP02,
                CCC = obj.CCC,
                PatientInformationId = obj.PatientInformationId



            };
            _db.VitalInfos.Add(serviceRequest);
            _db.SaveChanges();
            // return RedirectToAction("ServiceRequest", "GeneralUser");
           
            ViewBag.Message = "Request Sent to Consulting Successfully";
            ModelState.Clear();
            return View();
        }
    }
}

