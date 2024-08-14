using ALENGINE.Models;
using ALENGINE.Services;
using AMSEROIL.Service;
using AMSEROIL.Services;
using easyply.Service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using ALENGINE.Data;

namespace ALENGINE.Controllers
{
    public class HomeController : Controller
    {


        //injection
        private readonly ALENGINEContext _db;

      
        private readonly IMembersService _memberservice;
        
        
        public HomeController( IMembersService memberservice, ALENGINEContext db)
        {
          
            _memberservice = memberservice;
            _db = db;
        }

        [Authorize]
        public IActionResult Index()
        {
            totalrecords();
            totalmales();
            totalfemales();

            return View();
        }


        [Authorize]
        private void totalrecords()
        {

            var totalrecords = _db.PatientInformations.Count();
            ViewBag.totalrecords = totalrecords;
        }

        [Authorize]
        private void totalmales()
        {

            var totalmales = _db.PatientInformations.Where(x=>x.Sex == "Male");
            ViewBag.totalmales = totalmales.Count();
        }

        [Authorize]
        private void totalfemales()
        {

            var totalfemales = _db.PatientInformations.Where(x => x.Sex == "Female");
            ViewBag.totalfemales = totalfemales.Count();
        }

    }
}