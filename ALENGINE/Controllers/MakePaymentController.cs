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
    public class MakePaymentController : Controller
    {


        //injection
        private readonly ALENGINEContext _db;

        public MakePaymentController(ALENGINEContext db)
        {
            _db = db;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Payment(int id)
        {
            // return View(obj);
            var showdatabyID = _db.InitialPayments.FirstOrDefault(m => m.Id == id);
            var vm = (showdatabyID);



            return View(vm);
        }

        [HttpPost]
        public IActionResult Payment([FromForm] InitialPayment obj)
        {
          
            _db.InitialPayments.Add(obj);
            _db.SaveChanges();
            // return RedirectToAction("ServiceRequest", "GeneralUser");

            ViewBag.Message = "Request Sent Successfully";
            ModelState.Clear();
            return View();
        }
        
    }
}

