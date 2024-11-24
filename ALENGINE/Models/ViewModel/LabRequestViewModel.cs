namespace ALENGINE.Models.ViewModel
{
    public class LabRequestViewModel
    {
        public int Id { get; set; }
        public int PatientInformationId { get; set; }
        public string? LabRequestDetails { get; set; }
        public string? RegistrationNumber { get; set; }
        public string? CCC { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now.Date;

        internal static LabRequestViewModel labviewdt(VitalInfo? obj)
        {
            return new LabRequestViewModel
            {
                PatientInformationId = obj.PatientInformationId,
                RegistrationNumber = obj.RegistrationNumber,
                CCC = obj.CCC,

            };
        }
    }
}
