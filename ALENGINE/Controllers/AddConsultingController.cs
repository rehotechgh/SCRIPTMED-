using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALENGINE.Data;
using ALENGINE.Models;
using ALENGINE.Models.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ALENGINE.Controllers
{
    public class AddConsultingController : Controller
    {

        //injection
        private readonly ALENGINEContext _db;

        public AddConsultingController(ALENGINEContext db)
        {
            _db = db;
        }

        
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Consult(int id)
        {
            // return View(obj);
            adddescription();
            medlist();
           DiagnosisCategory();
            var showdatabyID = _db.VitalInfos.FirstOrDefault(m => m.PatientInformationId == id);
            var vm = ConsultingViewModel.ViewInitData(showdatabyID);
            ViewBag.lab = showdatabyID;



            return View(vm);
        }

        public IActionResult LabRequest(int id)
        {
            // return View(obj);
            adddescription();
            medlist();
            DiagnosisCategory();
            var showdatabyID = _db.VitalInfos.FirstOrDefault(m => m.PatientInformationId == id);
            var vm = ConsultingViewModel.ViewInitData(showdatabyID);
            ViewBag.lab = showdatabyID;



            return View(vm);
        }


        [HttpPost]
        public IActionResult LabRequest([FromForm] ConsultingViewModel obj)
        {
            var serviceRequest = new LabRequest

            {
               
              //  PatientInformationId = obj.PatientInformationId,
                FacilityNo = obj.FacilityNo,
                PatientType = obj.PatientType,
                RequestingPhysician = obj.RequestingPhysician,
                RequestPreparedBy = obj.RequestPreparedBy,
                ClinicalDiagnoses = obj.ClinicalDiagnoses,
                LabRequestDetails = obj.LabRequestDetails


            };
            _db.LabRequests.Add(serviceRequest);
            _db.SaveChanges();
            // return RedirectToAction("ServiceRequest", "GeneralUser");

            ViewBag.Message = "Lab Request  Details Saved Successfully!";
            ModelState.Clear();
            return View();
        }

        [HttpPost]
        public IActionResult Consult([FromForm] ConsultingViewModel obj)
        {
            var serviceRequest = new Central

            {
                RegistrationNumber = obj.RegistrationNumber,
                Surname = obj.Surname,
                OtherNames = obj.OtherNames,
                Examination= obj.Examination,
                Treatment = obj.Treatment,
                Request = obj.Request,
                LabType = obj.LabType,
                Dispensary = obj.DispensaryType,
                SetAppointment = obj.SetAppointment,
                AppointmentDate = obj.AppointmentDate,
                TypeOfService = obj.DispensaryType,
                Outcome = obj.Outcome,
                VisitationType = obj.VisitationType,
                VisitationDate = obj.VisitationType,
                Procedure1 = obj.Procedure1,
                Procedure2 = obj.Procedure2,
                Procedure3 = obj.Procedure3,
                PDescription1 = obj.PDescription1,
                PDescription2 = obj.PDescription2,
                PDescription3 = obj.PDescription3,
                Pdate1 = obj.Pdate1,
                Pdate2 = obj.Pdate2,
                Pdate3 = obj.Pdate3,
                PDRG1 = obj.PDRG1,
                PDRG2 = obj.PDRG2,
                PDRG3 = obj.PDRG3,
                Diagnosis1 = obj.Diagnosis1,
                Diagnosis2 = obj.Diagnosis2,
                Diagnosis3 = obj.Diagnosis3,
                Diagnosis4 = obj.Diagnosis4,
                Diagnosis5 = obj.Diagnosis5,
                Diagnosis6 = obj.Diagnosis6,
                DiagnosisCategory1 = obj.DiagnosisCategory1,
                DiagnosisCategory2 = obj.DiagnosisCategory2,
                DiagnosisCategory3 = obj.DiagnosisCategory3,
                DiagnosisCategory4 = obj.DiagnosisCategory4,
                DiagnosisCategory5 = obj.DiagnosisCategory5,
                DiagnosisCategory6 = obj.DiagnosisCategory6,
                DDescription1 = obj.DDescription1,
                DDescription2 = obj.DDescription2,
                DDescription3 = obj.DDescription3,
                DDescription4 = obj.DDescription4,
                DICD1 = obj.DICD1,
                DICD2 = obj.DICD2,
                DICD3  = obj.DICD3,
                DICD4 = obj.DICD4,
                DICD5 = obj.DICD5,
                DICD6 = obj.DICD6,
                DIDRG1 = obj.DIDRG1,
                DIDRG2 = obj.DIDRG2,
                DIDRG3 = obj.DIDRG3,
                DIDRG4 = obj.DIDRG4,
                DIDRG5 = obj.DIDRG5,
                DIDRG6 = obj.DIDRG6,
                Investigation1 = obj.Investigation1,
                Investigation2 = obj.Investigation2,
                Investigation3  = obj.Investigation3,
                Investigation4 = obj.Investigation4,
                Investigation5 = obj.Investigation5,
                IDescription1 = obj.IDescription1,
                IDescription2 = obj.IDescription2,
                IDescription3 = obj.IDescription3,
                IDescription4 = obj.IDescription4,
                IDescription5 = obj.IDescription5,
                IDate1 = obj.IDate1,
                IDate2 = obj.IDate2,
                IDate3 = obj.IDate3,
                IDate4 = obj.IDate4,
                IDate5 = obj.IDate5,
                IGDRG1 = obj.IGDRG1,
                IGDRG2 = obj.IGDRG2,
                IGDRG3 = obj.IGDRG3,
                IGDRG4 = obj.IGDRG4,
                IGDRG5 = obj.IGDRG5,  
                TUNIT  = obj.TUNIT,
                ClaimsStatus = obj.ClaimsStatus,
                HistoryIntake = obj.HistoryIntake,
                PatientInformationId = obj.PatientInformationId
                


            };
            _db.Centrals.Add(serviceRequest);
            _db.SaveChanges();
            // return RedirectToAction("ServiceRequest", "GeneralUser");
          
            ViewBag.Message = "Consulting Details Saved Successfully!";
            ModelState.Clear();
            return View();
        }

        private void adddescription()
        {

            var description = _db.Diagnoses.Select(x =>  new SelectListItem()
            {
                Text = x.Code,
                Value = x.Code
            }
            
            );
            ViewBag.Description = description;
        }


        private void medlist()
        {

            var description = _db.MedicineLists.Select(x => new SelectListItem()
            {
                Text = x.CODE,
                Value = x.CODE
            }

            );
            ViewBag.Medlist = description;
        }
       private void DiagnosisCategory()
       {

          var description = _db.DiagnosisCategories.Select(x => new SelectListItem()
           {
               Text = x.Category,
               Value = x.Category
           }

          );
         ViewBag.DiagnosisCategory = description;
       }
    }
}

