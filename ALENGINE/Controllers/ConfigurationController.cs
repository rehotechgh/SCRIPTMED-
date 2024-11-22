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
    public class ConfigurationController : Controller
    {


        //injection
        private readonly ALENGINEContext _db;

        public ConfigurationController(ALENGINEContext db)
        {
            _db = db;
        }

        // GET: /<controller>/


        public IActionResult Index()
        {
            
            return View();
        }
    }
}

