using System;
namespace ALENGINE.Models
{
	public class InitialPayment
	{


        public int Id { get; set; }
        public string? RegistrationNumber { get; set; }
        public string? Surname { get; set; }
        public string? OtherNames { get; set; }
        public string? HomeAddress { get; set; }
        public string? Telephone { get; set; }
        public string? HealthInsuranceNumber { get; set; }
        public string? DOB { get; set; }
        public int Age { get; set; }
        public string? Sex { get; set; }
        public string? DateOfFirstVisit { get; set; }

        public string? CCC { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now.Date;

    }
}


