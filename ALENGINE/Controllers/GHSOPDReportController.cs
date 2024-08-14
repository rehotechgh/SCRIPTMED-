using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALENGINE.Data;
using Humanizer;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ALENGINE.Controllers
{
    public class GHSOPDReportController : Controller
    {


        //injection
        private readonly ALENGINEContext _db;

        public GHSOPDReportController(ALENGINEContext db)
        {
            _db = db;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
           //0-28-11months
            zeroageMNEW();
            zeroageFNEW();
            zeroageMOLD();
            zeroageFOLD();
            additionmales();
            additionfemales();

            //1-to-4 years
            zeroageMNEW1TO4();
            zeroageFNEW1TO4();
            zeroageMOLD1TO4();
            zeroageFOLD1TO4();
            additionmales1to4();
            additionfemales1to4();

            //5TO9
            fiveto9MNEW();
            fiveto9FNEW();
            fiveto9MOLD();
            fiveto9FOLD();
            additionmales5to9();
            additionfemales1to5();
           

            //10to14
            tento14MNEW();
            tento14FNEW();
            tento14MOLD();
            tento14FOLD();
            additionmales10to14();
            additionfemales10to14();

            //15to17
            fifteento17MNEW();
            fifteento17FNEW();
            fifteento17MOLD();
            fifteento17FOLD();

            //18to19
            eighteenteento19MNEW();
            eighteenteento19FNEW();
            eighteenteento19MOLD();
            eighteenteento19FOLD();
            additionmales18to19();
            additionfemales18to19();

            //20to34
            twentynto34MNEW();
            twentynto34FNEW();
            twentynto34MOLD();
            twentynto34FOLD();

            //34to45
            thirty4to45MNEW();
            thirty4to45NEW();
            thirty4to45MOLD();
            thirty4to45FOLD();

            //45TO50
            fourty5to50MNEW();
            fourty5to50FNEW();
            fourty5to50MOLD();
            fourty5to50FOLD();

            //50to59
            fiftyto59MNEW();
            fiftyto59FNEW();
            fiftyto59MFOLD();
            fiftyto59FFOLD();

            //60to69
            sixtyto69MNEW();
            sixtyto69FNEW();
            sixtyto69MFOLD();
            sixtyto69FFOLD();

            //>70
            seventyMNEW();
            seventyFNEW();
            seventyMOLD();
            seventyFOLD();

            //None-insured

            //0-28-11months
            zeroageMNEW2();
            zeroageFNEW2();
            zeroageMOLD2();
            zeroageFOLD2();

            //1-to-4 years
            zeroageMNEW1TO42();
            zeroageFNEW1TO42();
            zeroageMOLD1TO42();
            zeroageFOLD1TO42();

            //5TO9
            fiveto9MNEW2();
            fiveto9FNEW2();
            fiveto9MOLD2();
            fiveto9FOLD2();

            //10to14
            tento14MNEW2();
            tento14FNEW2();
            tento14MOLD2();
            tento14FOLD2();

            //15to17
            fifteento17MNEW2();
            fifteento17FNEW2();
            fifteento17MOLD2();
            fifteento17FOLD2();
            additionmales15to17();
            additionfemales15to17();

            //18to19
            eighteenteento19MNEW2();
            eighteenteento19FNEW2();
            eighteenteento19MOLD2();
            eighteenteento19FOLD2();

            //20to34
            twentynto34MNEW2();
            twentynto34FNEW2();
            twentynto34MOLD2();
            twentynto34FOLD2();
            additionmales20to34();
            additionfemales20to34();

            //34to45
            thirty4to45MNEW2();
            thirty4to45NEW2();
            thirty4to45MOLD2();
            thirty4to45FOLD2();
            additionmales35to45();
            additionfemales35to45();

            //45TO50
            fourty5to50MNEW2();
            fourty5to50FNEW2();
            fourty5to50MOLD2();
            fourty5to50FOLD2();
            additionmales45to50();
            additionfemales45to50();

            //50to59
            fiftyto59MNEW2();
            fiftyto59FNEW2();
            fiftyto59MFOLD2();
            fiftyto59FFOLD2();
            additionmales50to59();
            additionfemales50to59();

            //60to69
            sixtyto69MNEW2();
            sixtyto69FNEW2();
            sixtyto69MFOLD2();
            sixtyto69FFOLD2();
            additionmales60to69();
            additionfemales60to69();

            //>70
            seventyMNEW2();
            seventyFNEW2();
            seventyMOLD2();
            seventyFOLD2();
            additionmales70();
            additionfemales70();






            return View();
        }

        //0 - 28 and 11 months
        public void zeroageMNEW()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age ==0 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex=="Male");
            ViewBag.zeroagemnew = zeroage.Count();
        }
        public void zeroageFNEW()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age == 0 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Female");
            ViewBag.zeroagefnew = zeroage.Count();
        }

        public void zeroageMOLD()
        {
            // var startdate = DateTime.Now.Date;
            // startdate = new DateTime(startdate.Year, startdate.Month, 1);

            //  var enddate = DateTime.Now.Date;
            //  enddate = enddate.AddMonths(-1);

            var today = DateTime.Today;
            var max = new DateTime(today.Year, today.Month, 1); // first of this month
            var min = max.AddMonths(-1); // first of last month

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age == 0 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Male");
            ViewBag.zeroagMeold = zeroageOLD.Count();
        }
        public void zeroageFOLD()
        {
            var today = DateTime.Today;
            var max = new DateTime(today.Year, today.Month, 1); // first of this month
            var min = max.AddMonths(-1); // first of last month

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age == 0 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Female");
            ViewBag.zeroageFold = zeroageOLD.Count();
        }


        //1-4 years
        private void zeroageMNEW1TO4()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 1 && x.Age <= 4 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male" );
            ViewBag.zeroagemnew1to4 = zeroage.Count();
        }
        private void zeroageFNEW1TO4()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 1 && x.Age <= 4 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Female");
            ViewBag.zeroagefnew1to4 = zeroage.Count();
        }

        private void zeroageMOLD1TO4()
        {
            var today = DateTime.Today;
            var max = new DateTime(today.Year, today.Month, 1); // first of this month
            var min = max.AddMonths(-1); // first of last month

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 1 && x.Age<=4 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Male");
            ViewBag.zeroagMeold1to4 = zeroageOLD.Count();
        }
        private void zeroageFOLD1TO4()
        {
            var today = DateTime.Today;
            var max = new DateTime(today.Year, today.Month, 1); // first of this month
            var min = max.AddMonths(-1); // first of last month

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 1 && x.Age <=4 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Female");
            ViewBag.zeroageFold1to4 = zeroageOLD.Count();
        }

        //5 to 9 years
        private void fiveto9MNEW()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 5 && x.Age <= 9 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male");
            ViewBag.zeroagemnew5to9 = zeroage.Count();
        }
        private void fiveto9FNEW()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 5 && x.Age <= 9 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Female");
            ViewBag.zeroagefnew5to9 = zeroage.Count();
        }

        private void fiveto9MOLD()
        {
            var today = DateTime.Today;
            var max = new DateTime(today.Year, today.Month, 1); // first of this month
            var min = max.AddMonths(-1); // first of last month

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 5 && x.Age <= 9 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Male");
            ViewBag.zeroagMeold5to9 = zeroageOLD.Count();
        }
        private void fiveto9FOLD()
        {
            var today = DateTime.Today;
            var max = new DateTime(today.Year, today.Month, 1); // first of this month
            var min = max.AddMonths(-1); // first of last month

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 5 && x.Age <= 9 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Female");
            ViewBag.zeroageFold5to9 = zeroageOLD.Count();
        }

        //10 TO 14
        private void tento14MNEW()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 10 && x.Age <= 14 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male");
            ViewBag.zeroagemnew10to14 = zeroage.Count();
        }
        private void tento14FNEW()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 10 && x.Age <= 14 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Female");
            ViewBag.zeroagefnew10to14 = zeroage.Count();
        }

        private void tento14MOLD()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(-1);

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 10 && x.Age <= 14 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male");
            ViewBag.zeroagMeold10to14 = zeroageOLD.Count();
        }
        private void tento14FOLD()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(-1);

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 10 && x.Age <= 14 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Female");
            ViewBag.zeroageFold10to14 = zeroageOLD.Count();
        }

        

        //15to17
        private void fifteento17MNEW()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 15 && x.Age <= 17 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male");
            ViewBag.zeroagemnew15to17 = zeroage.Count();
        }
        private void fifteento17FNEW()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 15 && x.Age <= 17 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Female");
            ViewBag.zeroagefnew15to17 = zeroage.Count();
        }

        private void fifteento17MOLD()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(-1);

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 15 && x.Age <= 17 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male");
            ViewBag.zeroagMeold15to17 = zeroageOLD.Count();
        }
        private void fifteento17FOLD()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(-1);

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 15 && x.Age <= 17 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Female");
            ViewBag.zeroageFold15to17 = zeroageOLD.Count();
        }

        //18to19
        private void eighteenteento19MNEW()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 18 && x.Age <= 19 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male");
            ViewBag.zeroagemnew18to19 = zeroage.Count();
        }
        private void eighteenteento19FNEW()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 18 && x.Age <= 19 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Female");
            ViewBag.zeroagefnew18to19 = zeroage.Count();
        }

        private void eighteenteento19MOLD()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(-1);

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 18 && x.Age <= 19 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male");
            ViewBag.zeroagMeold18to19 = zeroageOLD.Count();
        }
        private void eighteenteento19FOLD()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(-1);

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 18 && x.Age <= 19 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Female");
            ViewBag.zeroageFold18to19 = zeroageOLD.Count();
        }

        //20to34
        private void twentynto34MNEW()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 20 && x.Age <= 34 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male");
            ViewBag.zeroagemnew20to34 = zeroage.Count();
        }
        private void twentynto34FNEW()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 20 && x.Age <= 34 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Female");
            ViewBag.zeroagefnew20to34 = zeroage.Count();
        }

        private void twentynto34MOLD()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(-1);

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 20 && x.Age <= 34 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male");
            ViewBag.zeroagMeold20to34 = zeroageOLD.Count();
        }
        private void twentynto34FOLD()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(-1);

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 20 && x.Age <= 34 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Female");
            ViewBag.zeroageFold20to34 = zeroageOLD.Count();
        }

        //34to45
        private void thirty4to45MNEW()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 34 && x.Age <= 45 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male");
            ViewBag.zeroagemnew34to45 = zeroage.Count();
        }
        private void thirty4to45NEW()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 34 && x.Age <= 45 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Female");
            ViewBag.zeroagefnew34to45 = zeroage.Count();
        }

        private void thirty4to45MOLD()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(-1);

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 34 && x.Age <= 45 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male");
            ViewBag.zeroagMeold34to45 = zeroageOLD.Count();
        }
        private void thirty4to45FOLD()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(-1);

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 34 && x.Age <= 45 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Female");
            ViewBag.zeroageFold34to45 = zeroageOLD.Count();
        }

        //45TO50
        private void fourty5to50MNEW()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 45 && x.Age <= 50 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male");
            ViewBag.zeroagemnew45to50 = zeroage.Count();
        }
        private void fourty5to50FNEW()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 45 && x.Age <= 50 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Female");
            ViewBag.zeroagefnew45to50 = zeroage.Count();
        }

        private void fourty5to50MOLD()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(-1);

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 45 && x.Age <= 50 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male");
            ViewBag.zeroagMeold45to50 = zeroageOLD.Count();
        }
        private void fourty5to50FOLD()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(-1);

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 45 && x.Age <= 50 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Female");
            ViewBag.zeroageFold45to50 = zeroageOLD.Count();
        }





        private void fiftyto59MNEW()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 50 && x.Age <= 59 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male");
            ViewBag.fityto59MNEW = zeroage.Count();
        }
        private void fiftyto59FNEW()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 50 && x.Age <= 59 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Female");
            ViewBag.fiftyto59FNEW = zeroage.Count();
        }

        private void fiftyto59MFOLD()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(-1);

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 50 && x.Age <= 59 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male");
            ViewBag.fiftyto59MOLD = zeroageOLD.Count();
        }
        private void fiftyto59FFOLD()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(-1);

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 50 && x.Age <= 59 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male");
            ViewBag.fiftyto59FOLD = zeroageOLD.Count();
        }

        //60TO69
        private void sixtyto69MNEW()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 60 && x.Age <= 69 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male");
            ViewBag.sixtyto69MNEW = zeroage.Count();
        }
        private void sixtyto69FNEW()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 60 && x.Age <= 69 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Female");
            ViewBag.sixtyto69FNEW = zeroage.Count();
        }

        private void sixtyto69MFOLD()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(-1);

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 50 && x.Age <= 59 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male");
            ViewBag.sixtyto69MOLD = zeroageOLD.Count();
        }
        private void sixtyto69FFOLD()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(-1);

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 50 && x.Age <= 59 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male");
            ViewBag.sixtyto69FOLD = zeroageOLD.Count();
        }

        //>70
        private void seventyMNEW()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 70 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male");
            ViewBag.seventymnew = zeroage.Count();
        }
        private void seventyFNEW()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 70 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Female");
            ViewBag.seventyfnew = zeroage.Count();
        }

        private void seventyMOLD()
        {
            // var startdate = DateTime.Now.Date;
            // startdate = new DateTime(startdate.Year, startdate.Month, 1);

            //  var enddate = DateTime.Now.Date;
            //  enddate = enddate.AddMonths(-1);

            var today = DateTime.Today;
            var max = new DateTime(today.Year, today.Month, 1); // first of this month
            var min = max.AddMonths(-1); // first of last month

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 70 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Male");
            ViewBag.seventyMeold = zeroageOLD.Count();
        }
        private void seventyFOLD()
        {
            var today = DateTime.Today;
            var max = new DateTime(today.Year, today.Month, 1); // first of this month
            var min = max.AddMonths(-1); // first of last month

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 70 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Female");
            ViewBag.seventyFold = zeroageOLD.Count();
        }

        //ADDITION ALL MALES n FEMALES IN INSURED
        private void additionmales()
        {
            var startdatemnew = DateTime.Now.Date;
            startdatemnew = new DateTime(startdatemnew.Year, startdatemnew.Month, 1);

            var enddatemnew = startdatemnew.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age == 0 && x.DateCreated >= startdatemnew && x.DateCreated < enddatemnew && x.Sex == "Male");

            var today = DateTime.Today;
            var max = new DateTime(today.Year, today.Month, 1); // first of this month
            var min = max.AddMonths(-1); // first of last month

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age == 0 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Male");
           
            //none
            var startdatefmnonenew = DateTime.Now.Date;
            startdatefmnonenew = new DateTime(startdatefmnonenew.Year, startdatefmnonenew.Month, 1);

            var enddate = startdatefmnonenew.AddMonths(1);

            var zeroagmenonenew = _db.PatientInformations.Where(x => x.Age == 0 && x.DateCreated >= startdatefmnonenew && x.DateCreated < enddate && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");

            var todaynonemold = DateTime.Today;
            

            var zeroagemnoneOLD = _db.PatientInformations.Where(x => x.Age == 0 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.totalmales0to11 = zeroage.Count() + zeroageOLD.Count() + zeroagmenonenew.Count() + zeroagemnoneOLD.Count();

        }
        private void additionfemales()
        {
            var startdatemnew = DateTime.Now.Date;
            startdatemnew = new DateTime(startdatemnew.Year, startdatemnew.Month, 1);

            var enddatemnew = startdatemnew.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age == 0 && x.DateCreated >= startdatemnew && x.DateCreated < enddatemnew && x.Sex == "Female");

            var today = DateTime.Today;
            var max = new DateTime(today.Year, today.Month, 1); // first of this month
            var min = max.AddMonths(-1); // first of last month

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age == 0 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Female");

            //none
            var startdatefmnonenew = DateTime.Now.Date;
            startdatefmnonenew = new DateTime(startdatefmnonenew.Year, startdatefmnonenew.Month, 1);

            var enddate = startdatefmnonenew.AddMonths(1);

            var zeroagmenonenew = _db.PatientInformations.Where(x => x.Age == 0 && x.DateCreated >= startdatefmnonenew && x.DateCreated < enddate && x.Sex == "Female" && x.HealthInsuranceNumber == "NON INSURED");

            var todaynonemold = DateTime.Today;


            var zeroagemnoneOLD = _db.PatientInformations.Where(x => x.Age == 0 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Female" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.totalfemales0to11 = zeroage.Count() + zeroageOLD.Count() + zeroagmenonenew.Count() + zeroagemnoneOLD.Count();

        }
        private void additionmales1to4()
        {
            var startdatemnew = DateTime.Now.Date;
            startdatemnew = new DateTime(startdatemnew.Year, startdatemnew.Month, 1);

            var enddatemnew = startdatemnew.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 1 && x.Age <= 4 && x.DateCreated >= startdatemnew && x.DateCreated < enddatemnew && x.Sex == "Male");

            var today = DateTime.Today;
            var max = new DateTime(today.Year, today.Month, 1); // first of this month
            var min = max.AddMonths(-1); // first of last month

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 1 && x.Age <= 4 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Male");

            //none
            var startdatefmnonenew = DateTime.Now.Date;
            startdatefmnonenew = new DateTime(startdatefmnonenew.Year, startdatefmnonenew.Month, 1);

            var enddate = startdatefmnonenew.AddMonths(1);

            var zeroagmenonenew = _db.PatientInformations.Where(x => x.Age >= 1 && x.Age <= 4 && x.DateCreated >= startdatefmnonenew && x.DateCreated < enddate && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");

            var todaynonemold = DateTime.Today;


            var zeroagemnoneOLD = _db.PatientInformations.Where(x => x.Age >= 1 && x.Age <= 4  && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.totalmales1to4 = zeroage.Count() + zeroageOLD.Count() + zeroagmenonenew.Count() + zeroagemnoneOLD.Count();


        }
       
        private void additionfemales1to4()
        {
            var startdatemnew = DateTime.Now.Date;
            startdatemnew = new DateTime(startdatemnew.Year, startdatemnew.Month, 1);

            var enddatemnew = startdatemnew.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 1 && x.Age <= 4 && x.DateCreated >= startdatemnew && x.DateCreated < enddatemnew && x.Sex == "Female");

            var today = DateTime.Today;
            var max = new DateTime(today.Year, today.Month, 1); // first of this month
            var min = max.AddMonths(-1); // first of last month

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 1 && x.Age <= 4 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Female");

            //none
            var startdatefmnonenew = DateTime.Now.Date;
            startdatefmnonenew = new DateTime(startdatefmnonenew.Year, startdatefmnonenew.Month, 1);

            var enddate = startdatefmnonenew.AddMonths(1);

            var zeroagmenonenew = _db.PatientInformations.Where(x => x.Age >= 1 && x.Age <= 4 && x.DateCreated >= startdatefmnonenew && x.DateCreated < enddate && x.Sex == "Female" && x.HealthInsuranceNumber == "NON INSURED");

            var todaynonemold = DateTime.Today;


            var zeroagemnoneOLD = _db.PatientInformations.Where(x => x.Age >= 1 && x.Age <= 4 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "female" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.totalfemales1to4 = zeroage.Count() + zeroageOLD.Count() + zeroagmenonenew.Count() + zeroagemnoneOLD.Count();

        }

        private void additionmales5to9()
        {
            var startdatemnew = DateTime.Now.Date;
            startdatemnew = new DateTime(startdatemnew.Year, startdatemnew.Month, 1);

            var enddatemnew = startdatemnew.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 5 && x.Age <= 9 && x.DateCreated >= startdatemnew && x.DateCreated < enddatemnew && x.Sex == "Male");

            var today = DateTime.Today;
            var max = new DateTime(today.Year, today.Month, 1); // first of this month
            var min = max.AddMonths(-1); // first of last month

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 5 && x.Age <= 9 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Male");

            //none
            var startdatefmnonenew = DateTime.Now.Date;
            startdatefmnonenew = new DateTime(startdatefmnonenew.Year, startdatefmnonenew.Month, 1);

            var enddate = startdatefmnonenew.AddMonths(1);

            var zeroagmenonenew = _db.PatientInformations.Where(x => x.Age >= 5 && x.Age <= 9 && x.DateCreated >= startdatefmnonenew && x.DateCreated < enddate && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");

            var todaynonemold = DateTime.Today;


            var zeroagemnoneOLD = _db.PatientInformations.Where(x => x.Age >= 5 && x.Age <= 9 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.totalmales1to5 = zeroage.Count() + zeroageOLD.Count() + zeroagmenonenew.Count() + zeroagemnoneOLD.Count();


        }
        private void additionfemales1to5()
        {
            var startdatemnew = DateTime.Now.Date;
            startdatemnew = new DateTime(startdatemnew.Year, startdatemnew.Month, 1);

            var enddatemnew = startdatemnew.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 5 && x.Age <= 9 && x.DateCreated >= startdatemnew && x.DateCreated < enddatemnew && x.Sex == "Female");

            var today = DateTime.Today;
            var max = new DateTime(today.Year, today.Month, 1); // first of this month
            var min = max.AddMonths(-1); // first of last month

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 5 && x.Age <= 9 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Female");

            //none
            var startdatefmnonenew = DateTime.Now.Date;
            startdatefmnonenew = new DateTime(startdatefmnonenew.Year, startdatefmnonenew.Month, 1);

            var enddate = startdatefmnonenew.AddMonths(1);

            var zeroagmenonenew = _db.PatientInformations.Where(x => x.Age >= 1 && x.Age <= 5 && x.DateCreated >= startdatefmnonenew && x.DateCreated < enddate && x.Sex == "Female" && x.HealthInsuranceNumber == "NON INSURED");

            var todaynonemold = DateTime.Today;


            var zeroagemnoneOLD = _db.PatientInformations.Where(x => x.Age >= 5 && x.Age <= 9 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "female" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.totalfemales1to5 = zeroage.Count() + zeroageOLD.Count() + zeroagmenonenew.Count() + zeroagemnoneOLD.Count();

        }

        private void additionmales10to14()
        {
            var startdatemnew = DateTime.Now.Date;
            startdatemnew = new DateTime(startdatemnew.Year, startdatemnew.Month, 1);

            var enddatemnew = startdatemnew.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 10 && x.Age <= 14 && x.DateCreated >= startdatemnew && x.DateCreated < enddatemnew && x.Sex == "Male");

            var today = DateTime.Today;
            var max = new DateTime(today.Year, today.Month, 1); // first of this month
            var min = max.AddMonths(-1); // first of last month

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 10 && x.Age <= 14 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Male");

            //none
            var startdatefmnonenew = DateTime.Now.Date;
            startdatefmnonenew = new DateTime(startdatefmnonenew.Year, startdatefmnonenew.Month, 1);

            var enddate = startdatefmnonenew.AddMonths(1);

            var zeroagmenonenew = _db.PatientInformations.Where(x => x.Age >= 10 && x.Age <= 14 && x.DateCreated >= startdatefmnonenew && x.DateCreated < enddate && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");

            var todaynonemold = DateTime.Today;


            var zeroagemnoneOLD = _db.PatientInformations.Where(x => x.Age >= 10 && x.Age <= 14 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.totalmales10to14 = zeroage.Count() + zeroageOLD.Count() + zeroagmenonenew.Count() + zeroagemnoneOLD.Count();


        }
        private void additionfemales10to14()
        {
            var startdatemnew = DateTime.Now.Date;
            startdatemnew = new DateTime(startdatemnew.Year, startdatemnew.Month, 1);

            var enddatemnew = startdatemnew.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 1 && x.Age <= 5 && x.DateCreated >= startdatemnew && x.DateCreated < enddatemnew && x.Sex == "Female");

            var today = DateTime.Today;
            var max = new DateTime(today.Year, today.Month, 1); // first of this month
            var min = max.AddMonths(-1); // first of last month

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 10 && x.Age <= 14 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Female");

            //none
            var startdatefmnonenew = DateTime.Now.Date;
            startdatefmnonenew = new DateTime(startdatefmnonenew.Year, startdatefmnonenew.Month, 1);

            var enddate = startdatefmnonenew.AddMonths(1);

            var zeroagmenonenew = _db.PatientInformations.Where(x => x.Age >= 10 && x.Age <= 14 && x.DateCreated >= startdatefmnonenew && x.DateCreated < enddate && x.Sex == "Female" && x.HealthInsuranceNumber == "NON INSURED");

            var todaynonemold = DateTime.Today;


            var zeroagemnoneOLD = _db.PatientInformations.Where(x => x.Age >= 1 && x.Age <= 5 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "female" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.totalfemales10to14 = zeroage.Count() + zeroageOLD.Count() + zeroagmenonenew.Count() + zeroagemnoneOLD.Count();

        }
        
        private void additionmales15to17()
        {
            var startdatemnew = DateTime.Now.Date;
            startdatemnew = new DateTime(startdatemnew.Year, startdatemnew.Month, 1);

            var enddatemnew = startdatemnew.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 15 && x.Age <= 17 && x.DateCreated >= startdatemnew && x.DateCreated < enddatemnew && x.Sex == "Male");

            var today = DateTime.Today;
            var max = new DateTime(today.Year, today.Month, 1); // first of this month
            var min = max.AddMonths(-1); // first of last month

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 15 && x.Age <= 17 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Male");

            //none
            var startdatefmnonenew = DateTime.Now.Date;
            startdatefmnonenew = new DateTime(startdatefmnonenew.Year, startdatefmnonenew.Month, 1);

            var enddate = startdatefmnonenew.AddMonths(1);

            var zeroagmenonenew = _db.PatientInformations.Where(x => x.Age >= 15 && x.Age <= 17 && x.DateCreated >= startdatefmnonenew && x.DateCreated < enddate && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");

            var todaynonemold = DateTime.Today;


            var zeroagemnoneOLD = _db.PatientInformations.Where(x => x.Age >= 15 && x.Age <= 17 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.totalmales15to17 = zeroage.Count() + zeroageOLD.Count() + zeroagmenonenew.Count() + zeroagemnoneOLD.Count();


        }
        private void additionfemales15to17()
        {
            var startdatemnew = DateTime.Now.Date;
            startdatemnew = new DateTime(startdatemnew.Year, startdatemnew.Month, 1);

            var enddatemnew = startdatemnew.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 15 && x.Age <= 17 && x.DateCreated >= startdatemnew && x.DateCreated < enddatemnew && x.Sex == "Female");

            var today = DateTime.Today;
            var max = new DateTime(today.Year, today.Month, 1); // first of this month
            var min = max.AddMonths(-1); // first of last month

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 15 && x.Age <= 17 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Female");

            //none
            var startdatefmnonenew = DateTime.Now.Date;
            startdatefmnonenew = new DateTime(startdatefmnonenew.Year, startdatefmnonenew.Month, 1);

            var enddate = startdatefmnonenew.AddMonths(1);

            var zeroagmenonenew = _db.PatientInformations.Where(x => x.Age >= 15 && x.Age <= 17 && x.DateCreated >= startdatefmnonenew && x.DateCreated < enddate && x.Sex == "Female" && x.HealthInsuranceNumber == "NON INSURED");

            var todaynonemold = DateTime.Today;


            var zeroagemnoneOLD = _db.PatientInformations.Where(x => x.Age >= 15 && x.Age <= 17 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "female" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.totalfemales15to17 = zeroage.Count() + zeroageOLD.Count() + zeroagmenonenew.Count() + zeroagemnoneOLD.Count();

        }

        private void additionmales18to19()
        {
            var startdatemnew = DateTime.Now.Date;
            startdatemnew = new DateTime(startdatemnew.Year, startdatemnew.Month, 1);

            var enddatemnew = startdatemnew.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 18 && x.Age <= 19 && x.DateCreated >= startdatemnew && x.DateCreated < enddatemnew && x.Sex == "Male");

            var today = DateTime.Today;
            var max = new DateTime(today.Year, today.Month, 1); // first of this month
            var min = max.AddMonths(-1); // first of last month

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 18 && x.Age <= 19 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Male");

            //none
            var startdatefmnonenew = DateTime.Now.Date;
            startdatefmnonenew = new DateTime(startdatefmnonenew.Year, startdatefmnonenew.Month, 1);

            var enddate = startdatefmnonenew.AddMonths(1);

            var zeroagmenonenew = _db.PatientInformations.Where(x => x.Age >= 18 && x.Age <= 19 && x.DateCreated >= startdatefmnonenew && x.DateCreated < enddate && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");

            var todaynonemold = DateTime.Today;


            var zeroagemnoneOLD = _db.PatientInformations.Where(x => x.Age >= 18 && x.Age <= 19 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.totalmales18to19 = zeroage.Count() + zeroageOLD.Count() + zeroagmenonenew.Count() + zeroagemnoneOLD.Count();


        }
        private void additionfemales18to19()
        {
            var startdatemnew = DateTime.Now.Date;
            startdatemnew = new DateTime(startdatemnew.Year, startdatemnew.Month, 1);

            var enddatemnew = startdatemnew.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 18 && x.Age <= 19 && x.DateCreated >= startdatemnew && x.DateCreated < enddatemnew && x.Sex == "Female");

            var today = DateTime.Today;
            var max = new DateTime(today.Year, today.Month, 1); // first of this month
            var min = max.AddMonths(-1); // first of last month

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 18 && x.Age <= 19 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Female");

            //none
            var startdatefmnonenew = DateTime.Now.Date;
            startdatefmnonenew = new DateTime(startdatefmnonenew.Year, startdatefmnonenew.Month, 1);

            var enddate = startdatefmnonenew.AddMonths(1);

            var zeroagmenonenew = _db.PatientInformations.Where(x => x.Age >= 18 && x.Age <= 19 && x.DateCreated >= startdatefmnonenew && x.DateCreated < enddate && x.Sex == "Female" && x.HealthInsuranceNumber == "NON INSURED");

            var todaynonemold = DateTime.Today;


            var zeroagemnoneOLD = _db.PatientInformations.Where(x => x.Age >= 18 && x.Age <= 19 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "female" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.totalfemales18to19 = zeroage.Count() + zeroageOLD.Count() + zeroagmenonenew.Count() + zeroagemnoneOLD.Count();

        }

        private void additionmales20to34()
        {
            var startdatemnew = DateTime.Now.Date;
            startdatemnew = new DateTime(startdatemnew.Year, startdatemnew.Month, 1);

            var enddatemnew = startdatemnew.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 20 && x.Age <= 34 && x.DateCreated >= startdatemnew && x.DateCreated < enddatemnew && x.Sex == "Male");

            var today = DateTime.Today;
            var max = new DateTime(today.Year, today.Month, 1); // first of this month
            var min = max.AddMonths(-1); // first of last month

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 20 && x.Age <= 34 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Male");

            //none
            var startdatefmnonenew = DateTime.Now.Date;
            startdatefmnonenew = new DateTime(startdatefmnonenew.Year, startdatefmnonenew.Month, 1);

            var enddate = startdatefmnonenew.AddMonths(1);

            var zeroagmenonenew = _db.PatientInformations.Where(x => x.Age >= 20 && x.Age <= 34 && x.DateCreated >= startdatefmnonenew && x.DateCreated < enddate && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");

            var todaynonemold = DateTime.Today;


            var zeroagemnoneOLD = _db.PatientInformations.Where(x => x.Age >= 20 && x.Age <= 34 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.totalmales20to34 = zeroage.Count() + zeroageOLD.Count() + zeroagmenonenew.Count() + zeroagemnoneOLD.Count();


        }
        private void additionfemales20to34()
        {
            var startdatemnew = DateTime.Now.Date;
            startdatemnew = new DateTime(startdatemnew.Year, startdatemnew.Month, 1);

            var enddatemnew = startdatemnew.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 20 && x.Age <= 34 && x.DateCreated >= startdatemnew && x.DateCreated < enddatemnew && x.Sex == "Female");

            var today = DateTime.Today;
            var max = new DateTime(today.Year, today.Month, 1); // first of this month
            var min = max.AddMonths(-1); // first of last month

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 20 && x.Age <= 34 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Female");

            //none
            var startdatefmnonenew = DateTime.Now.Date;
            startdatefmnonenew = new DateTime(startdatefmnonenew.Year, startdatefmnonenew.Month, 1);

            var enddate = startdatefmnonenew.AddMonths(1);

            var zeroagmenonenew = _db.PatientInformations.Where(x => x.Age >= 20 && x.Age <= 34 && x.DateCreated >= startdatefmnonenew && x.DateCreated < enddate && x.Sex == "Female" && x.HealthInsuranceNumber == "NON INSURED");

            var todaynonemold = DateTime.Today;


            var zeroagemnoneOLD = _db.PatientInformations.Where(x => x.Age >= 20 && x.Age <= 34 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "female" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.totalfemales20to34 = zeroage.Count() + zeroageOLD.Count() + zeroagmenonenew.Count() + zeroagemnoneOLD.Count();

        }

        private void additionmales35to45()
        {
            var startdatemnew = DateTime.Now.Date;
            startdatemnew = new DateTime(startdatemnew.Year, startdatemnew.Month, 1);

            var enddatemnew = startdatemnew.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 35 && x.Age <= 45 && x.DateCreated >= startdatemnew && x.DateCreated < enddatemnew && x.Sex == "Male");

            var today = DateTime.Today;
            var max = new DateTime(today.Year, today.Month, 1); // first of this month
            var min = max.AddMonths(-1); // first of last month

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 35 && x.Age <= 45 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Male");

            //none
            var startdatefmnonenew = DateTime.Now.Date;
            startdatefmnonenew = new DateTime(startdatefmnonenew.Year, startdatefmnonenew.Month, 1);

            var enddate = startdatefmnonenew.AddMonths(1);

            var zeroagmenonenew = _db.PatientInformations.Where(x => x.Age >= 35 && x.Age <= 45 && x.DateCreated >= startdatefmnonenew && x.DateCreated < enddate && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");

            var todaynonemold = DateTime.Today;


            var zeroagemnoneOLD = _db.PatientInformations.Where(x => x.Age >= 35 && x.Age <= 45 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.totalmales35to45 = zeroage.Count() + zeroageOLD.Count() + zeroagmenonenew.Count() + zeroagemnoneOLD.Count();


        }
        private void additionfemales35to45()
        {
            var startdatemnew = DateTime.Now.Date;
            startdatemnew = new DateTime(startdatemnew.Year, startdatemnew.Month, 1);

            var enddatemnew = startdatemnew.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 35 && x.Age <= 45 && x.DateCreated >= startdatemnew && x.DateCreated < enddatemnew && x.Sex == "Female");

            var today = DateTime.Today;
            var max = new DateTime(today.Year, today.Month, 1); // first of this month
            var min = max.AddMonths(-1); // first of last month

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 35 && x.Age <= 45 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Female");

            //none
            var startdatefmnonenew = DateTime.Now.Date;
            startdatefmnonenew = new DateTime(startdatefmnonenew.Year, startdatefmnonenew.Month, 1);

            var enddate = startdatefmnonenew.AddMonths(1);

            var zeroagmenonenew = _db.PatientInformations.Where(x => x.Age >= 35 && x.Age <= 45 && x.DateCreated >= startdatefmnonenew && x.DateCreated < enddate && x.Sex == "Female" && x.HealthInsuranceNumber == "NON INSURED");

            var todaynonemold = DateTime.Today;


            var zeroagemnoneOLD = _db.PatientInformations.Where(x => x.Age >= 35 && x.Age <= 45 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "female" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.totalfemales35to45 = zeroage.Count() + zeroageOLD.Count() + zeroagmenonenew.Count() + zeroagemnoneOLD.Count();

        }

        private void additionmales45to50()
        {
            var startdatemnew = DateTime.Now.Date;
            startdatemnew = new DateTime(startdatemnew.Year, startdatemnew.Month, 1);

            var enddatemnew = startdatemnew.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 45 && x.Age <= 50 && x.DateCreated >= startdatemnew && x.DateCreated < enddatemnew && x.Sex == "Male");

            var today = DateTime.Today;
            var max = new DateTime(today.Year, today.Month, 1); // first of this month
            var min = max.AddMonths(-1); // first of last month

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 45 && x.Age <= 50 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Male");

            //none
            var startdatefmnonenew = DateTime.Now.Date;
            startdatefmnonenew = new DateTime(startdatefmnonenew.Year, startdatefmnonenew.Month, 1);

            var enddate = startdatefmnonenew.AddMonths(1);

            var zeroagmenonenew = _db.PatientInformations.Where(x => x.Age >= 45 && x.Age <= 50 && x.DateCreated >= startdatefmnonenew && x.DateCreated < enddate && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");

            var todaynonemold = DateTime.Today;


            var zeroagemnoneOLD = _db.PatientInformations.Where(x => x.Age >= 45 && x.Age <= 50 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.totalmales45to50 = zeroage.Count() + zeroageOLD.Count() + zeroagmenonenew.Count() + zeroagemnoneOLD.Count();


        }
        private void additionfemales45to50()
        {
            var startdatemnew = DateTime.Now.Date;
            startdatemnew = new DateTime(startdatemnew.Year, startdatemnew.Month, 1);

            var enddatemnew = startdatemnew.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 45 && x.Age <= 50 && x.DateCreated >= startdatemnew && x.DateCreated < enddatemnew && x.Sex == "Female");

            var today = DateTime.Today;
            var max = new DateTime(today.Year, today.Month, 1); // first of this month
            var min = max.AddMonths(-1); // first of last month

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 45 && x.Age <= 50 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Female");

            //none
            var startdatefmnonenew = DateTime.Now.Date;
            startdatefmnonenew = new DateTime(startdatefmnonenew.Year, startdatefmnonenew.Month, 1);

            var enddate = startdatefmnonenew.AddMonths(1);

            var zeroagmenonenew = _db.PatientInformations.Where(x => x.Age >= 20 && x.Age <= 34 && x.DateCreated >= startdatefmnonenew && x.DateCreated < enddate && x.Sex == "Female" && x.HealthInsuranceNumber == "NON INSURED");

            var todaynonemold = DateTime.Today;


            var zeroagemnoneOLD = _db.PatientInformations.Where(x => x.Age >= 45 && x.Age <= 50 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "female" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.totalfemales45to50 = zeroage.Count() + zeroageOLD.Count() + zeroagmenonenew.Count() + zeroagemnoneOLD.Count();

        }

        private void additionmales50to59()
        {
            var startdatemnew = DateTime.Now.Date;
            startdatemnew = new DateTime(startdatemnew.Year, startdatemnew.Month, 1);

            var enddatemnew = startdatemnew.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 50 && x.Age <= 59 && x.DateCreated >= startdatemnew && x.DateCreated < enddatemnew && x.Sex == "Male");

            var today = DateTime.Today;
            var max = new DateTime(today.Year, today.Month, 1); // first of this month
            var min = max.AddMonths(-1); // first of last month

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 50 && x.Age <= 59 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Male");

            //none
            var startdatefmnonenew = DateTime.Now.Date;
            startdatefmnonenew = new DateTime(startdatefmnonenew.Year, startdatefmnonenew.Month, 1);

            var enddate = startdatefmnonenew.AddMonths(1);

            var zeroagmenonenew = _db.PatientInformations.Where(x => x.Age >= 50 && x.Age <= 59 && x.DateCreated >= startdatefmnonenew && x.DateCreated < enddate && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");

            var todaynonemold = DateTime.Today;


            var zeroagemnoneOLD = _db.PatientInformations.Where(x => x.Age >= 50 && x.Age <= 59 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.totalmales50to59 = zeroage.Count() + zeroageOLD.Count() + zeroagmenonenew.Count() + zeroagemnoneOLD.Count();


        }
        private void additionfemales50to59()
        {
            var startdatemnew = DateTime.Now.Date;
            startdatemnew = new DateTime(startdatemnew.Year, startdatemnew.Month, 1);

            var enddatemnew = startdatemnew.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 50 && x.Age <= 59 && x.DateCreated >= startdatemnew && x.DateCreated < enddatemnew && x.Sex == "Female");

            var today = DateTime.Today;
            var max = new DateTime(today.Year, today.Month, 1); // first of this month
            var min = max.AddMonths(-1); // first of last month

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 50 && x.Age <= 59 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Female");

            //none
            var startdatefmnonenew = DateTime.Now.Date;
            startdatefmnonenew = new DateTime(startdatefmnonenew.Year, startdatefmnonenew.Month, 1);

            var enddate = startdatefmnonenew.AddMonths(1);

            var zeroagmenonenew = _db.PatientInformations.Where(x => x.Age >= 50 && x.Age <= 59 && x.DateCreated >= startdatefmnonenew && x.DateCreated < enddate && x.Sex == "Female" && x.HealthInsuranceNumber == "NON INSURED");

            var todaynonemold = DateTime.Today;


            var zeroagemnoneOLD = _db.PatientInformations.Where(x => x.Age >= 50 && x.Age <= 59 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "female" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.totalfemales50to59 = zeroage.Count() + zeroageOLD.Count() + zeroagmenonenew.Count() + zeroagemnoneOLD.Count();

        }

        private void additionmales60to69()
        {
            var startdatemnew = DateTime.Now.Date;
            startdatemnew = new DateTime(startdatemnew.Year, startdatemnew.Month, 1);

            var enddatemnew = startdatemnew.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 60 && x.Age <= 69 && x.DateCreated >= startdatemnew && x.DateCreated < enddatemnew && x.Sex == "Male");

            var today = DateTime.Today;
            var max = new DateTime(today.Year, today.Month, 1); // first of this month
            var min = max.AddMonths(-1); // first of last month

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 60 && x.Age <= 69 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Male");

            //none
            var startdatefmnonenew = DateTime.Now.Date;
            startdatefmnonenew = new DateTime(startdatefmnonenew.Year, startdatefmnonenew.Month, 1);

            var enddate = startdatefmnonenew.AddMonths(1);

            var zeroagmenonenew = _db.PatientInformations.Where(x => x.Age >= 60 && x.Age <= 69 && x.DateCreated >= startdatefmnonenew && x.DateCreated < enddate && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");

            var todaynonemold = DateTime.Today;


            var zeroagemnoneOLD = _db.PatientInformations.Where(x => x.Age >= 60 && x.Age <= 69 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.totalmales60to69 = zeroage.Count() + zeroageOLD.Count() + zeroagmenonenew.Count() + zeroagemnoneOLD.Count();


        }
        private void additionfemales60to69()
        {
            var startdatemnew = DateTime.Now.Date;
            startdatemnew = new DateTime(startdatemnew.Year, startdatemnew.Month, 1);

            var enddatemnew = startdatemnew.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 60 && x.Age <= 69 && x.DateCreated >= startdatemnew && x.DateCreated < enddatemnew && x.Sex == "Female");

            var today = DateTime.Today;
            var max = new DateTime(today.Year, today.Month, 1); // first of this month
            var min = max.AddMonths(-1); // first of last month

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 50 && x.Age <= 59 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Female");

            //none
            var startdatefmnonenew = DateTime.Now.Date;
            startdatefmnonenew = new DateTime(startdatefmnonenew.Year, startdatefmnonenew.Month, 1);

            var enddate = startdatefmnonenew.AddMonths(1);

            var zeroagmenonenew = _db.PatientInformations.Where(x => x.Age >= 60 && x.Age <= 69 && x.DateCreated >= startdatefmnonenew && x.DateCreated < enddate && x.Sex == "Female" && x.HealthInsuranceNumber == "NON INSURED");

            var todaynonemold = DateTime.Today;


            var zeroagemnoneOLD = _db.PatientInformations.Where(x => x.Age >= 60 && x.Age <= 69 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "female" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.totalfemales60to69 = zeroage.Count() + zeroageOLD.Count() + zeroagmenonenew.Count() + zeroagemnoneOLD.Count();

        }

        private void additionmales70()
        {
            var startdatemnew = DateTime.Now.Date;
            startdatemnew = new DateTime(startdatemnew.Year, startdatemnew.Month, 1);

            var enddatemnew = startdatemnew.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 70  && x.DateCreated >= startdatemnew && x.DateCreated < enddatemnew && x.Sex == "Male");

            var today = DateTime.Today;
            var max = new DateTime(today.Year, today.Month, 1); // first of this month
            var min = max.AddMonths(-1); // first of last month

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 70  && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Male");

            //none
            var startdatefmnonenew = DateTime.Now.Date;
            startdatefmnonenew = new DateTime(startdatefmnonenew.Year, startdatefmnonenew.Month, 1);

            var enddate = startdatefmnonenew.AddMonths(1);

            var zeroagmenonenew = _db.PatientInformations.Where(x => x.Age >= 70  && x.DateCreated >= startdatefmnonenew && x.DateCreated < enddate && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");

            var todaynonemold = DateTime.Today;


            var zeroagemnoneOLD = _db.PatientInformations.Where(x => x.Age >= 70  && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.totalmales70 = zeroage.Count() + zeroageOLD.Count() + zeroagmenonenew.Count() + zeroagemnoneOLD.Count();


        }
        private void additionfemales70()
        {
            var startdatemnew = DateTime.Now.Date;
            startdatemnew = new DateTime(startdatemnew.Year, startdatemnew.Month, 1);

            var enddatemnew = startdatemnew.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 70 &&  x.DateCreated >= startdatemnew && x.DateCreated < enddatemnew && x.Sex == "Female");

            var today = DateTime.Today;
            var max = new DateTime(today.Year, today.Month, 1); // first of this month
            var min = max.AddMonths(-1); // first of last month

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 70 &&  x.DateCreated >= min && x.DateCreated < max && x.Sex == "Female");

            //none
            var startdatefmnonenew = DateTime.Now.Date;
            startdatefmnonenew = new DateTime(startdatefmnonenew.Year, startdatefmnonenew.Month, 1);

            var enddate = startdatefmnonenew.AddMonths(1);

            var zeroagmenonenew = _db.PatientInformations.Where(x => x.Age >= 70 && x.DateCreated >= startdatefmnonenew && x.DateCreated < enddate && x.Sex == "Female" && x.HealthInsuranceNumber == "NON INSURED");

            var todaynonemold = DateTime.Today;


            var zeroagemnoneOLD = _db.PatientInformations.Where(x => x.Age >= 70 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "female" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.totalfemales70 = zeroage.Count() + zeroageOLD.Count() + zeroagmenonenew.Count() + zeroagemnoneOLD.Count();

        }



        //NONE-INSURED
        //0 - 28 and 11 months
        private void zeroageMNEW2()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age == 0 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male" && x.HealthInsuranceNumber== "NON INSURED");
            ViewBag.zeroagemnew2 = zeroage.Count();
        }
        private void zeroageFNEW2()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age == 0 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Female" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.zeroagefnew2 = zeroage.Count();
        }

        private void zeroageMOLD2()
        {
            // var startdate = DateTime.Now.Date;
            // startdate = new DateTime(startdate.Year, startdate.Month, 1);

            //  var enddate = DateTime.Now.Date;
            //  enddate = enddate.AddMonths(-1);

            var today = DateTime.Today;
            var max = new DateTime(today.Year, today.Month, 1); // first of this month
            var min = max.AddMonths(-1); // first of last month

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age == 0 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.zeroagMeold2 = zeroageOLD.Count();
        }
        private void zeroageFOLD2()
        {
            var today = DateTime.Today;
            var max = new DateTime(today.Year, today.Month, 1); // first of this month
            var min = max.AddMonths(-1); // first of last month

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age == 0 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Female" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.zeroageFold2 = zeroageOLD.Count();
        }


        //1-4 years
        private void zeroageMNEW1TO42()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 1 && x.Age <= 4 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.zeroagemnew1to42 = zeroage.Count();
        }
        private void zeroageFNEW1TO42()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 1 && x.Age <= 4 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Female" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.zeroagefnew1to42 = zeroage.Count();
        }

        private void zeroageMOLD1TO42()
        {
            var today = DateTime.Today;
            var max = new DateTime(today.Year, today.Month, 1); // first of this month
            var min = max.AddMonths(-1); // first of last month

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 1 && x.Age <= 4 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.zeroagMeold1to42 = zeroageOLD.Count();
        }
        private void zeroageFOLD1TO42()
        {
            var today = DateTime.Today;
            var max = new DateTime(today.Year, today.Month, 1); // first of this month
            var min = max.AddMonths(-1); // first of last month

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 1 && x.Age <= 4 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Female" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.zeroageFold1to42 = zeroageOLD.Count();
        }

        //5 to 9 years
        private void fiveto9MNEW2()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 5 && x.Age <= 9 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.zeroagemnew5to92 = zeroage.Count();
        }
        private void fiveto9FNEW2()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 5 && x.Age <= 9 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Female" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.zeroagefnew5to92 = zeroage.Count();
        }

        private void fiveto9MOLD2()
        {
            var today = DateTime.Today;
            var max = new DateTime(today.Year, today.Month, 1); // first of this month
            var min = max.AddMonths(-1); // first of last month

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 5 && x.Age <= 9 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.zeroagMeold5to92 = zeroageOLD.Count();
        }
        private void fiveto9FOLD2()
        {
            var today = DateTime.Today;
            var max = new DateTime(today.Year, today.Month, 1); // first of this month
            var min = max.AddMonths(-1); // first of last month

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 5 && x.Age <= 9 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Female" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.zeroageFold5to92 = zeroageOLD.Count();
        }

        //10 TO 14
        private void tento14MNEW2()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 10 && x.Age <= 14 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.zeroagemnew10to142 = zeroage.Count();
        }
        private void tento14FNEW2()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 10 && x.Age <= 14 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Female" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.zeroagefnew10to142 = zeroage.Count();
        }

        private void tento14MOLD2()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(-1);

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 10 && x.Age <= 14 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.zeroagMeold10to142 = zeroageOLD.Count();
        }
        private void tento14FOLD2()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(-1);

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 10 && x.Age <= 14 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Female" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.zeroageFold10to142 = zeroageOLD.Count();
        }



        //15to17
        private void fifteento17MNEW2()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 15 && x.Age <= 17 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.zeroagemnew15to172 = zeroage.Count();
        }
        private void fifteento17FNEW2()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 15 && x.Age <= 17 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Female" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.zeroagefnew15to172 = zeroage.Count();
        }

        private void fifteento17MOLD2()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(-1);

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 15 && x.Age <= 17 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.zeroagMeold15to172 = zeroageOLD.Count();
        }
        private void fifteento17FOLD2()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(-1);

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 15 && x.Age <= 17 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Female" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.zeroageFold15to172 = zeroageOLD.Count();
        }

        //18to19
        private void eighteenteento19MNEW2()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 18 && x.Age <= 19 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male");
            ViewBag.zeroagemnew18to192 = zeroage.Count();
        }
        private void eighteenteento19FNEW2()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 18 && x.Age <= 19 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Female" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.zeroagefnew18to192 = zeroage.Count();
        }

        private void eighteenteento19MOLD2()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(-1);

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 18 && x.Age <= 19 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.zeroagMeold18to192 = zeroageOLD.Count();
        }
        private void eighteenteento19FOLD2()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(-1);

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 18 && x.Age <= 19 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Female" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.zeroageFold18to192 = zeroageOLD.Count();
        }

        //20to34
        private void twentynto34MNEW2()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 20 && x.Age <= 34 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.zeroagemnew20to342 = zeroage.Count();
        }
        private void twentynto34FNEW2()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 20 && x.Age <= 34 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Female" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.zeroagefnew20to342 = zeroage.Count();
        }

        private void twentynto34MOLD2()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(-1);

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 20 && x.Age <= 34 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.zeroagMeold20to342 = zeroageOLD.Count();
        }
        private void twentynto34FOLD2()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(-1);

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 20 && x.Age <= 34 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Female" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.zeroageFold20to342 = zeroageOLD.Count();
        }

        //34to45
        private void thirty4to45MNEW2()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 34 && x.Age <= 45 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.zeroagemnew34to452 = zeroage.Count();
        }
        private void thirty4to45NEW2()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 34 && x.Age <= 45 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Female" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.zeroagefnew34to452 = zeroage.Count();
        }

        private void thirty4to45MOLD2()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(-1);

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 34 && x.Age <= 45 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.zeroagMeold34to452 = zeroageOLD.Count();
        }
        private void thirty4to45FOLD2()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(-1);

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 34 && x.Age <= 45 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Female");
            ViewBag.zeroageFold34to452 = zeroageOLD.Count();
        }

        //45TO50
        private void fourty5to50MNEW2()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 45 && x.Age <= 50 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.zeroagemnew45to502 = zeroage.Count();
        }
        private void fourty5to50FNEW2()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 45 && x.Age <= 50 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Female" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.zeroagefnew45to502 = zeroage.Count();
        }

        private void fourty5to50MOLD2()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(-1);

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 45 && x.Age <= 50 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.zeroagMeold45to502 = zeroageOLD.Count();
        }
        private void fourty5to50FOLD2()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(-1);

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 45 && x.Age <= 50 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Female" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.zeroageFold45to502 = zeroageOLD.Count();
        }





        private void fiftyto59MNEW2()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 50 && x.Age <= 59 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.fityto59MNEW2 = zeroage.Count();
        }
        private void fiftyto59FNEW2()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 50 && x.Age <= 59 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Female" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.fiftyto59FNEW2 = zeroage.Count();
        }

        private void fiftyto59MFOLD2()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(-1);

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 50 && x.Age <= 59 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.fiftyto59MOLD2 = zeroageOLD.Count();
        }
        private void fiftyto59FFOLD2()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(-1);

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 50 && x.Age <= 59 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.fiftyto59FOLD2 = zeroageOLD.Count();
        }

        //60TO69
        private void sixtyto69MNEW2()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 60 && x.Age <= 69 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.sixtyto69MNEW2 = zeroage.Count();
        }
        private void sixtyto69FNEW2()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 60 && x.Age <= 69 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Female" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.sixtyto69FNEW2 = zeroage.Count();
        }

        private void sixtyto69MFOLD2()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(-1);

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 50 && x.Age <= 59 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.sixtyto69MOLD2 = zeroageOLD.Count();
        }
        private void sixtyto69FFOLD2()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(-1);

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 50 && x.Age <= 59 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.sixtyto69FOLD2 = zeroageOLD.Count();
        }

        //>70
        private void seventyMNEW2()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 70 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.seventymnew2 = zeroage.Count();
        }
        private void seventyFNEW2()
        {
            var startdate = DateTime.Now.Date;
            startdate = new DateTime(startdate.Year, startdate.Month, 1);

            var enddate = startdate.AddMonths(1);

            var zeroage = _db.PatientInformations.Where(x => x.Age >= 70 && x.DateCreated >= startdate && x.DateCreated < enddate && x.Sex == "Female" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.seventyfnew2 = zeroage.Count();
        }

        private void seventyMOLD2()
        {
            // var startdate = DateTime.Now.Date;
            // startdate = new DateTime(startdate.Year, startdate.Month, 1);

            //  var enddate = DateTime.Now.Date;
            //  enddate = enddate.AddMonths(-1);

            var today = DateTime.Today;
            var max = new DateTime(today.Year, today.Month, 1); // first of this month
            var min = max.AddMonths(-1); // first of last month

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 70 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Male" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.seventyMeold2 = zeroageOLD.Count();
        }
        private void seventyFOLD2()
        {
            var today = DateTime.Today;
            var max = new DateTime(today.Year, today.Month, 1); // first of this month
            var min = max.AddMonths(-1); // first of last month

            var zeroageOLD = _db.PatientInformations.Where(x => x.Age >= 70 && x.DateCreated >= min && x.DateCreated < max && x.Sex == "Female" && x.HealthInsuranceNumber == "NON INSURED");
            ViewBag.seventyFold2 = zeroageOLD.Count();
        }
    }
}

