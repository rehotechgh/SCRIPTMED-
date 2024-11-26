using System;
namespace ALENGINE.Models.ViewModel
{
	public class ANCViewModel
	{
        public int Id { get; set; }
        public string? RegistrationNumber { get; set; }
     //   public int PatientInformationId { get; set; }
        public string? Surname { get; set; }
        public string? OtherNames { get; set; }
        public string? DOB { get; set; }
        public int Age { get; set; }
        public string? Sex { get; set; }
        public string? Husband { get; set; }
        public string? HusbandContact { get; set; }
        public string? HusbandOccupation { get; set; }
        public string? HusbandAddress { get; set; }
        public string? Examination { get; set; }
        public string? Treatment { get; set; }
        public string? LabRequest { get; set; }
        public string? LabType { get; set; }
        public string? Dispensary { get; set; }
        public string? DispensaryType { get; set; }
        public string? SetAppointment { get; set; }
        public string? AppointmentDate { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;

        internal static ANCViewModel ANCData(PatientInformation? initpayment)
        {
            return new ANCViewModel
            {


                //show data
                RegistrationNumber = initpayment.RegistrationNumber,
                Surname = initpayment.Surname,
                OtherNames = initpayment.OtherNames,
             //   PatientInformationId = initpayment.PatientInformationId,
                DOB = initpayment.DOB,
                Age = initpayment.Age,
                Sex = initpayment.Sex














            };
        }
    }


}

