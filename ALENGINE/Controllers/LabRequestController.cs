using ALENGINE.Data;
using ALENGINE.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ALENGINE.Controllers
{
    public class LabRequestController : Controller
    {

        private readonly ALENGINEContext _db;

        public LabRequestController(ALENGINEContext db)
        {
            _db = db;
        }

        public IActionResult Index(int id)
        {
            var showdatabyID = _db.VitalInfos.FirstOrDefault(m => m.Id == id);
            var vm = LabRequestViewModel.labviewdt(showdatabyID);

            return View();
        }
    }
}
