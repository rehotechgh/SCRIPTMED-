using ALENGINE.Data;
using ALENGINE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ALENGINE.Controllers
{
    public class ViewPostNatalController : Controller
    {

        //injection
        private readonly ALENGINEContext _db;

        public ViewPostNatalController(ALENGINEContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index([FromForm] Postnatal obj)
        {
           _db.Postnatals.Add(obj);
            _db.SaveChanges();
            ViewBag.Message = "Post Natal Records added successfully!";
            ModelState.Clear();
            
            return View();
        }


    }
}
