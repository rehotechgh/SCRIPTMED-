using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALENGINE.Data;
using ALENGINE.Models;
using ALENGINE.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ALENGINE.Controllers
{
    public class DispensaryController : Controller
    {
        //injection
        private readonly ALENGINEContext _db;

        public DispensaryController(ALENGINEContext db)
        {
            _db = db;
        }
        // GET: /<controller>/
        public IActionResult DrugPurchase(string Searchstring)
        {
            
          
            List<Inventory> pdt = _db.Inventories.ToList();

            ViewData["CurrentFilter"] = Searchstring;


            return View(pdt.Find(p => p.ItemName == Searchstring));
        }

        
        public IActionResult Index(int id)
        {
            // return View(obj);
            var showdatabyID = _db.Centrals.FirstOrDefault(m => m.Id == id);
            var vm = DispensaryViewModel.ViewDispenseryData(showdatabyID);



            return View(vm);
        }

        [HttpPost]
        public ActionResult SaveDrug([FromForm]DTransactionViewModel obj)
        {


            var serviceRequest = new InventoryTransaction

            {
                ItemName = obj.ItemName,
                ManufacturingDate = obj.ManufacturingDate,
                ExpiryDate = obj.ExpiryDate,
                Manufacturer = obj.Manufacturer,
                Quantity = obj.Quantity,
                CostPrice = obj.CostPrice,
                SalesPrice = obj.SalesPrice,
                SalesQuantity = obj.SalesQuantity,
                SalesAmount = obj.SalesAmount




            };

             _db.InventoryTransactions.Add(serviceRequest);
             _db.SaveChanges();


            //  return Json(_customer);
            return View();
        }


 

       

    }
}

