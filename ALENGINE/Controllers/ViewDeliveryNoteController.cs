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
    public class ViewDeliveryNoteController : Controller
    {
        //injection
        private readonly ALENGINEContext _db;

        public ViewDeliveryNoteController(ALENGINEContext db)
        {
            _db = db;
        }

        // GET: /<controller>/
        public IActionResult Index(int id)
        {
            // return View(obj);
            var showdatabyID = _db.ANCs.FirstOrDefault(m => m.Id == id);
            var vm = ViewANCDetailsModel.ANCDetails(showdatabyID);



            return View(vm);
        }
        [HttpPost]
        public IActionResult Index([FromForm] ViewANCDetailsModel obj)
        {
            var serviceRequest = new DeliveryNote

            {
                RegistrationNumber = obj.RegistrationNumber,
                Surname = obj.Surname,
                OtherNames = obj.OtherNames,

                DOB = obj.DOB,
                Age = obj.Age,
                Sex = obj.Sex,
                Weight= obj.Weight,
                WeightOfBaby= obj.WeightOfBaby,
                Height= obj.Height,
                BloodGroup = obj.BloodGroup,
                BloodPressure = obj.BloodPressure,
                Temperature = obj.Temperature,
                Pulse = obj.Pulse,
                SP02 = obj.SP02,
                GestationalAge = obj.GestationalAge,
                DeliveryTime = obj.DeliveryTime,
                ApgarScoreOfBaby = obj.ApgarScoreOfBaby,
                Observation = obj.Observation,
                Deliverynote = obj.Deliverynote

              




            };
            _db.DeliveryNotes.Add(serviceRequest);
            _db.SaveChanges();
            // return RedirectToAction("ServiceRequest", "GeneralUser");

            ViewBag.Message = "Delivery Note Saved Successfully";
            ModelState.Clear();
            return View();
        }
    }
}

