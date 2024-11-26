namespace ALENGINE.Models
{
    public class LabRequest
    {
        public int Id { get; set; }
       
        public string? RegistrationNumber { get; set; }
        public string? FacilityNo { get; set; }
        public string? PatientType { get; set; }
        public string? RequestingPhysician { get; set; }
        public string? RequestPreparedBy { get; set; }
        public string? ClinicalDiagnoses { get; set; }
        public string? LabRequestDetails { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now.Date;


    }
}
