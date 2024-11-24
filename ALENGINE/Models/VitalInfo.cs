using System;
namespace ALENGINE.Models
{
	public class VitalInfo
	{
        public int Id { get; set; }
        public string? RegistrationNumber { get; set; }
        public string? Surname { get; set; }
        public string? OtherNames { get; set; }
        public string? Weight { get; set; }
        public string? BloodGroup { get; set; }
        public string? BloodPressure { get; set; }
        public string? Temperature { get; set; }
        public string? Pulse { get; set; }
        public string? SP02 { get; set; }
        public string? Height { get; set; }

        public string? Condition { get; set; }
        public string? CCC { get; set; }
        public int PatientInformationId { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now.Date;

    }
}

