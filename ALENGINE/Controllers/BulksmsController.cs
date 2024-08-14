using ALENGINE.Data;
using ALENGINE.Models;
using easyply.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ALENGINE.Controllers
{
    public class BulksmsController : Controller
    {

        private readonly ALENGINEContext _db;

        public BulksmsController(ALENGINEContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
           

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index([FromForm] PatientInformation obj )
        {
           

             MessageService C = new MessageService();
            var rs = _db.PatientInformations.ToList();
            
            foreach (PatientInformation dr in rs)
            {
                await C.SendSMS(dr.Telephone, $"{obj.OtherNames}");
               
            }
            ViewBag.message = "Message Sent Successfully";
            return View(obj);
        }
    }
}
