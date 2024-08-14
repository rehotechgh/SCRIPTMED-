using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALENGINE.Data;
using ALENGINE.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ALENGINE.Controllers
{
    public class InitiatePaymentController : Controller
    {

        //injection
        private readonly ALENGINEContext _db;

        public InitiatePaymentController(ALENGINEContext db)
        {
            _db = db;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
           



            return View();
        }

        public IActionResult InitPayment(int id)
        {
            // return View(obj);
            var showdatabyID = _db.PatientInformations.FirstOrDefault(m => m.Id == id);
            var vm = InitiatePaymentViewModel.ViewInitData(showdatabyID);



            return View(vm);
        }

         [HttpPost]
        public IActionResult InitPayment([FromForm] InitiatePaymentViewModel obj)
        {
            var serviceRequest = new InitialPayment

            {
                RegistrationNumber = obj.RegistrationNumber,
                Surname = obj.Surname,
                OtherNames = obj.OtherNames,
                Telephone = obj.Telephone,
                HomeAddress = obj.HomeAddress,
                HealthInsuranceNumber = obj.HealthInsuranceNumber,
                DOB = obj.DOB,
                Age = obj.Age,
                Sex = obj.Sex,
                DateOfFirstVisit = obj.DateCreated.ToString(),
                CCC = obj.CCC



            };

            _db.InitialPayments.Add(serviceRequest);
            _db.SaveChanges();
            // return RedirectToAction("ServiceRequest", "GeneralUser");
          
            ViewBag.Message = "Request Sent to OPD Successfully";
            ModelState.Clear();
            return View();
        }

    }
}

