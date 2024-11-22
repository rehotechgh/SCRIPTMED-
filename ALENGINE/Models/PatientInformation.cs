using System.ComponentModel.DataAnnotations.Schema;

namespace ALENGINE.Models
{
    public class PatientInformation
    {
        public int Id { get; set; }

        public string? HealthFacilityNo { get; set; }
        public string? RegistrationNumber { get; set; }
        public string? SPCODE { get; set; }

        public string? FacilityName { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string? Surname { get; set; }
        public string? OtherNames { get; set; }
        public string? DOB { get; set; }
        public int Age { get; set; }
        public string? Sex { get; set; }
        public string? MaritalStatus { get; set; }
        public string? Occupation { get; set; }
        public string? Religion { get; set; }
        public string? PostalAddress { get; set; }
        public string? HomeAddress { get; set; }
        public string? Telephone { get; set; }
        public string? Email { get; set; }
        public string? NameOfNearestRelative { get; set; }
        public string? ContactOfNearestRealtive { get; set; }
        public string? District { get; set; }
        public string? SubDistrict_Locality { get; set; }
        public string? NameOfHealthInsuranceScheme { get; set; }
        public string? HealthInsuranceNumber { get; set; }
        public string? HealthInsuranceSchemeIDNumber { get; set; }
        public string? Payment { get; set; }






    }
}

