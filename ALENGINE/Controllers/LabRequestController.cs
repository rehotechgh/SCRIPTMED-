using ALENGINE.Data;
using ALENGINE.Models;
using ALENGINE.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.EJ2.Linq;

namespace ALENGINE.Controllers
{
    public class LabRequestController : Controller
    {

        private readonly ALENGINEContext _db;

        public LabRequestController(ALENGINEContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
           // var showdatabyID = _db.LabRequests.FirstOrDefault(m => m.PatientInformationId == id);
           IEnumerable<LabRequest> objlist = _db.LabRequests.ToList();


            return View(objlist);
        }
    }
}
