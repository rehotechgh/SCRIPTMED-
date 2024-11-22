using ALENGINE.Data;
using ALENGINE.Models;
using Microsoft.AspNetCore.Mvc;

namespace ALENGINE.Controllers
{
    public class AddDiagnosisCategoryController : Controller
    {


        //injection
        private readonly ALENGINEContext _db;

        public AddDiagnosisCategoryController(ALENGINEContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index([FromForm] DiagnosisCategory obj)
        {
           try
           {
            _db.DiagnosisCategories.Add(obj);
            _db.SaveChanges();
            ViewBag.Message = "Diagnosis category details added successfully!";
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
