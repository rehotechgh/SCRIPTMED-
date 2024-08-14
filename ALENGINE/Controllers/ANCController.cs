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
    public class ANCController : Controller
    {

        //injection
        private readonly ALENGINEContext _db;

        public ANCController(ALENGINEContext db)
        {
            _db = db;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ViewANC(int id)
        {
            // return View(obj);
            var showdatabyID = _db.PatientInformations.FirstOrDefault(m => m.Id == id);
            var vm = ANCViewModel.ANCData(showdatabyID);



            return View(vm);
        }

        [HttpPost]
        public IActionResult ViewANC([FromForm] ANCViewModel obj)
        {
            var serviceRequest = new ANC

            {
                RegistrationNumber = obj.RegistrationNumber,
                Surname = obj.Surname,
                OtherNames = obj.OtherNames,
                DOB = obj.DOB,
                Age = obj.Age,
                Sex = obj.Sex,
                Husband = obj.Husband,
                HusbandOccupation = obj.HusbandOccupation,
                HusbandAddress = obj.HusbandAddress,
                HusbandContact = obj.HusbandContact








            };
            _db.ANCs.Add(serviceRequest);
            _db.SaveChanges();
            // return RedirectToAction("ServiceRequest", "GeneralUser");

            ViewBag.Message = "ANC Records saved Successfully";
            ModelState.Clear();
            return View();
        }

    }
}

