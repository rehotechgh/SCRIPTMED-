using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALENGINE.Models;
using ALENGINE.Services;
using easyply.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ALENGINE.Controllers
{
    public class RecordsController : Controller
    {
        private readonly IMembersService _memberservice;

        public RecordsController(IMembersService memberservice)
        {

            _memberservice = memberservice;
        }


        // GET: /<controller>/
      //  [Authorize]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
       // [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([FromForm] PatientInformation obj)
        {
            await _memberservice.AddMembers(obj);

            //sms notification

            //var message = $"Welcome {obj.Firstname} {obj.Lastname} to AGAPE SDA CHURCH-PENKWASE.Your Member ID is: {obj.EmployeeID}.This would be used for all your Transactions.Thank you for being part of AGAPE SDA-CHURCH SUNYANI";
            //await _messageChannel.WriteAsync(new SMSNotification(obj.ContactNumber, message));

            try
            {
                MessageService C = new MessageService();
                await C.SendSMS(obj.Telephone, $"Welcome {obj.Surname} {obj.OtherNames} to AGI'S MATERNITY HOME | This is your your IDENTITY CARD.Your OPD No. is: {obj.RegistrationNumber}.Your Sex is {obj.Sex} and your Age is {obj.Age}.Your date of First admission is {obj.RegistrationDate}.Keep this carefully.Bring each time you attend clinic");
                ModelState.Clear();
                ViewBag.Message = "New Patient Record Saved Successfully";

               
            }
            catch (Exception)
            {
                ViewBag.Message = "Data Save Succesfully but SMS not Sent. Please check network";
            }
            ModelState.Clear();
            return View();

        }
    }
}

