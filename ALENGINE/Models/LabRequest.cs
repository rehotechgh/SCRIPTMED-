namespace ALENGINE.Models
{
    public class LabRequest
    {
        public int Id { get; set; }
        public int PatientInformationId { get; set; }
        public string? LabRequestDetails { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now.Date;


    }
}
