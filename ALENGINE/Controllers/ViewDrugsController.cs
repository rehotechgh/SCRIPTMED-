using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALENGINE.Data;
using ALENGINE.Models;
using ALENGINE.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ALENGINE.Controllers
{
    public class ViewDrugsController : Controller
    {

        //injection
        private readonly ALENGINEContext _db;

        public ViewDrugsController(ALENGINEContext db)
        {
            _db = db;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DrugDetails(int id)
        {
            // return View(obj);
            var showdatabyID = _db.Inventories.FirstOrDefault(m => m.Id == id);
            var vm = DTransactionViewModel.DDataEntry(showdatabyID);



            return View(vm);
        }

        [HttpPost]
        public IActionResult DrugDetails([FromForm] DTransactionViewModel obj, Inventory objj)
        {
            var serviceRequest = new InventoryTransaction

            {
               ItemName = obj.ItemName,
               ManufacturingDate = obj.ManufacturingDate,
               ExpiryDate = obj.ExpiryDate,
               Manufacturer = obj.Manufacturer,
               Quantity = obj.Quantity,
               CostPrice = obj.CostPrice,
               SalesQuantity = obj.SalesQuantity,
               SalesPrice = obj.SalesPrice,
               SalesAmount = obj.SalesAmount



            };

            _db.Inventories.Update(objj);
            _db.InventoryTransactions.Add(serviceRequest);
            _db.SaveChanges();
            // return RedirectToAction("ServiceRequest", "GeneralUser");

            ViewBag.Message = "Sales Transactions Saved Successfully !";
            ModelState.Clear();
            return View();
        }
    }
}

