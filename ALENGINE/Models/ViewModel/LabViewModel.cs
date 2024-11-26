namespace ALENGINE.Models.ViewModel
{
    public class LabViewModel
    {
        public string? RegistrationNumber { get; set; }
        public string? Surname { get; set; }
        public string? OtherNames { get; set; }
        public string? FacilityNo { get; set; }
        public string? PatientType { get; set; }
        public string? RequestingPhysician { get; set; }
        public string? RequestPreparedBy { get; set; }
        public string? ClinicalDiagnoses { get; set; }
        public string? LabRequestDetails { get; set; }

        internal static LabViewModel showlab(PatientInformation? obj)
        {
            return new LabViewModel
            {

                //show
                RegistrationNumber = obj.RegistrationNumber,
                Surname = obj.Surname,
                OtherNames = obj.OtherNames


            };
        }
    }
}
