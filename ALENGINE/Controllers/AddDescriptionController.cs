﻿using ALENGINE.Data;
using ALENGINE.Models;
using Microsoft.AspNetCore.Mvc;

namespace ALENGINE.Controllers
{
    public class AddDescriptionController : Controller
    {


        //injection
        private readonly ALENGINEContext _db;

        public AddDescriptionController(ALENGINEContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index([FromForm] Diagnose obj)
        {
           try
           {
            _db.Diagnoses.Add(obj);
            _db.SaveChanges();
            ViewBag.Message = "Description Details Saved Successfully!";
            ModelState.Clear();
       
           }
           catch (System.Exception)
           {
            
           ViewBag.Message = "Operation Unsuccessful! Try Again";
           }
     return View();

        }
    }
}
