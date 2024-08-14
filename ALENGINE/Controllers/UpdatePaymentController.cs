using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALENGINE.Data;
using ALENGINE.Models;
using easyply.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ALENGINE.Controllers
{
    public class UpdatePaymentController : Controller
    {
        //injection
        private readonly ALENGINEContext _db;

        public UpdatePaymentController(ALENGINEContext db)
        {
            _db = db;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

    //    [HttpPost]
     //   [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> ApprovePayment(InitialPayment obj)
   //     {

           // _db.InitialPayments.Update(obj);
           //_db.SaveChanges();
            //sms notification

          
           // MessageService C = new MessageService();
          //  await C.SendSMS(obj.Contact_Number, $"Hello {obj.Firstname} {obj.Lastname}. An amount of: {obj.Amount} has been received for your consultation! Kindly proceed to OPD.Thank you");
           // ModelState.Clear();
       
          //  ViewBag.Message = "Payment Updated Successfully!";
         //   return RedirectToAction("Payment", "MakePayment");
      //  }
    }
}

