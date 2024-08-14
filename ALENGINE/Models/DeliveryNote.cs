using System;
namespace ALENGINE.Models
{
	public class DeliveryNote
	{

        public int Id { get; set; }
        public string? RegistrationNumber { get; set; }
        public string? Surname { get; set; }
        public string? OtherNames { get; set; }
        public string? DOB { get; set; }
        public int Age { get; set; }
        public string? Sex { get; set; }
        public string? Observation { get; set; }
        public string? Deliverynote { get; set; }
        public string? Weight { get; set; }
        public string? BloodGroup { get; set; }
        public string? BloodPressure { get; set; }
        public string? Temperature { get; set; }
        public string? Pulse { get; set; }
        public string? SP02 { get; set; }
        public string? Height { get; set; }
        public string? GestationalAge { get; set; }
        public string? DeliveryTime { get; set; }
        public string? WeightOfBaby { get; set; }
        public string? ApgarScoreOfBaby { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;

    }
}

