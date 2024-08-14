using ALENGINE.Data;
using ALENGINE.Services;
using ALENGINE.Models;
using Microsoft.EntityFrameworkCore;

namespace AMSEROIL.Services
{
    public class MemberService : IMembersService
    {
        private readonly ALENGINEContext _db;
        private readonly IWebHostEnvironment _webHost;
        public MemberService(ALENGINEContext db, IWebHostEnvironment webHost)
        {
            _db = db;
            _webHost = webHost;
        }
        public async Task AddMembers(PatientInformation members)
        {



            var cdate = DateTime.Now.ToString("yyyy");
            var lastadmission = _db.PatientInformations.OrderByDescending(c => c.RegistrationNumber).FirstOrDefault();
            if (lastadmission == null)
            {
                members.RegistrationNumber = "AGMH"+ cdate + "001";
            }
            else
            {
                //using string substring method to get the number of the last inserted employee's EmployeeID 
                members.RegistrationNumber = "AGMH" +cdate+(Convert.ToInt32(lastadmission.RegistrationNumber.Substring(8, lastadmission.RegistrationNumber.Length - 8)) + 1).ToString("D3");


            }
            //image upload
           // string UniqueFileName = GetUploadFileName(members);
           // members.PhotoUrl = UniqueFileName;


            //save into registration and cashbook
            await _db.PatientInformations.AddAsync(members);
            await _db.SaveChangesAsync();
        }

    

        public Task DeleteMembers(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<PatientInformation> GetMembers(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<PatientInformation> GetMembersById(string Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PatientInformation>> ListPatient()
        {
            //return await _db.Employees.Find(x=>x.Location==location).ToListAsync();
            return await _db.PatientInformations.ToListAsync();
        }

        public Task UpdateMembers(PatientInformation  members)
        {
            throw new NotImplementedException();
        }


        //image upload function
       // private string GetUploadFileName(Members obj)
      //  {
            //string? uniqueFileName = null;

        //    if (obj.ProfilePhoto != null)
       //     {
              //  string uploadsFolder = Path.Combine(_webHost.WebRootPath, "Images");
             //   uniqueFileName = Guid.NewGuid().ToString() + "_" + obj.ProfilePhoto.FileName;
            //    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
            //    using (var fileStream = new FileStream(filePath, FileMode.Create))
            //    {
            //        obj.ProfilePhoto.CopyTo(fileStream);
            //    }


         //   }



          //  return uniqueFileName;

       // }

    }
}
