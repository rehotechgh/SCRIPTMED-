using System.ComponentModel.DataAnnotations.Schema;

namespace ALENGINE.Models
{
    public class InitiatePaymentViewModel
    {
        public int Id { get; set; }
        public string? RegistrationNumber { get; set; }
        public string? Surname { get; set; }
        public string? OtherNames { get; set; }
        public string? HomeAddress { get; set; }
        public string? Telephone { get; set; }
        public string? DOB { get; set; }
        public int Age { get; set; }

        public string? Sex { get; set; }
        public string? DateOfFirstVisit { get; set; }

        public string? HealthInsuranceNumber { get; set; }
        public string? CCC { get; set; }

     
        public DateTime DateCreated { get; set; } = DateTime.Now;

        internal static InitiatePaymentViewModel ViewInitData(PatientInformation? initpayment)
        {
            return new InitiatePaymentViewModel
            {


                //show data
                RegistrationNumber = initpayment.RegistrationNumber,
                Surname = initpayment.Surname,
                OtherNames = initpayment.OtherNames,
                HomeAddress = initpayment.HomeAddress,
                Telephone = initpayment.Telephone,
                DOB = initpayment.DOB,
                Age = initpayment.Age,
                Sex = initpayment.Sex,
                DateOfFirstVisit = initpayment.DateCreated.ToString(),
                HealthInsuranceNumber = initpayment.HealthInsuranceNumber,
                CCC = initpayment.Payment,
              











            };
        }



    }
}
