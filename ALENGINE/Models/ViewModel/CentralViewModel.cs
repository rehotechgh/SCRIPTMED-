namespace ALENGINE.Models.ViewModel
{
    public class CentralViewModel
    {
        public int Id { get; set; }
        public string? RegistrationNumber { get; set; }
        public string? Surname { get; set; }
        public string? OtherNames { get; set; }
        public string? Weight { get; set; }
        public string? BloodGroup { get; set; }
        public string? BloodPressure { get; set; }
        public string? Examination { get; set; }
        public string? Treatment { get; set; }
        public string? LabRequest { get; set; }
        public string? LabType { get; set; }
        public string? Dispensary { get; set; }
        public string? DispensaryType { get; set; }
        public string? SetAppointment { get; set; }
        public string? TypeOfService { get; set; }
        public string? Outcome { get; set; }
        public string? VisitationType { get; set; }
        public string? VisitationDate { get; set; }
        public string? Procedure1 { get; set; }
        public string? Procedure2 { get; set; }
        public string? Procedure3 { get; set; }
        public string? PDescription1 { get; set; }
        public string? PDescription2 { get; set; }
        public string? PDescription3 { get; set; }

        public string? Pdate1 { get; set; }
        public string? Pdate2 { get; set; }
        public string? Pdate3 { get; set; }
        public string? PDRG1 { get; set; }
        public string? PDRG2 { get; set; }
        public string? PDRG3 { get; set; }
        public string? Diagnosis1 { get; set; }
        public string? Diagnosis2 { get; set; }
        public string? Diagnosis3 { get; set; }
        public string? Diagnosis4 { get; set; }
        public string? DDescription1 { get; set; }
        public string? DDescription2 { get; set; }
        public string? DDescription3 { get; set; }
        public string? DDescription4 { get; set; }
        public string? DICD1 { get; set; }
        public string? DICD2 { get; set; }
        public string? DICD3 { get; set; }
        public string? DICD4 { get; set; }
        public string? DIDRG1 { get; set; }
        public string? DIDRG2 { get; set; }
        public string? DIDRG3 { get; set; }
        public string? DIDRG4 { get; set; }
        public string? Investigation1 { get; set; }
        public string? Investigation2 { get; set; }
        public string? Investigation3 { get; set; }
        public string? Investigation4 { get; set; }
        public string? Investigation5 { get; set; }
        public string? IDescription1 { get; set; }
        public string? IDescription2 { get; set; }
        public string? IDescription3 { get; set; }
        public string? IDescription4 { get; set; }
        public string? IDescription5 { get; set; }
        public string? IDate1 { get; set; }
        public string? IDate2 { get; set; }
        public string? IDate3 { get; set; }
        public string? IDate4 { get; set; }
        public string? IDate5 { get; set; }
        public string? IGDRG1 { get; set; }
        public string? IGDRG2 { get; set; }
        public string? IGDRG3 { get; set; }
        public string? IGDRG4 { get; set; }
        public string? IGDRG5 { get; set; }
        public string? TUNIT { get; set; }
        public string? ClaimsStatus { get; set; }
        public string? CCC { get; set; }
        public string? AppointmentDate { get; set; }

        public string? Height { get; set; }

        public string? Condition { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;

        internal static CentralViewModel ViewInitData(Central? obj)
        {
            return new CentralViewModel
            {


                //show data
                RegistrationNumber = obj.RegistrationNumber,
                Surname = obj.Surname,
                OtherNames = obj.OtherNames,
                Examination = obj.Examination,
                Treatment = obj.Treatment,
                LabRequest = obj.Request,
                LabType = obj.LabType,
                Dispensary = obj.DispensaryType,
                SetAppointment = obj.SetAppointment,
                AppointmentDate = obj.AppointmentDate,
                TypeOfService = obj.DispensaryType,
                Outcome = obj.Outcome,
                VisitationType = obj.VisitationType,
                VisitationDate = obj.VisitationType,
                Procedure1 = obj.Procedure1,
                Procedure2 = obj.Procedure2,
                Procedure3 = obj.Procedure3,
                PDescription1 = obj.PDescription1,
                PDescription2 = obj.PDescription2,
                PDescription3 = obj.PDescription3,
                Pdate1 = obj.Pdate1,
                Pdate2 = obj.Pdate2,
                Pdate3 = obj.Pdate3,
                PDRG1 = obj.PDRG1,
                PDRG2 = obj.PDRG2,
                PDRG3 = obj.PDRG3,
                Diagnosis1 = obj.Diagnosis1,
                Diagnosis2 = obj.Diagnosis2,
                Diagnosis3 = obj.Diagnosis3,
                Diagnosis4 = obj.Diagnosis4,
                DDescription1 = obj.DDescription1,
                DDescription2 = obj.DDescription2,
                DDescription3 = obj.DDescription3,
                DDescription4 = obj.DDescription4,
                DICD1 = obj.DICD1,
                DICD2 = obj.DICD2,
                DICD3 = obj.DICD3,
                DICD4 = obj.DICD4,
                DIDRG1 = obj.DIDRG1,
                DIDRG2 = obj.DIDRG2,
                DIDRG3 = obj.DIDRG3,
                DIDRG4 = obj.DIDRG4,
                Investigation1 = obj.Investigation1,
                Investigation2 = obj.Investigation2,
                Investigation3 = obj.Investigation3,
                Investigation4 = obj.Investigation4,
                Investigation5 = obj.Investigation5,
                IDescription1 = obj.IDescription1,
                IDescription2 = obj.IDescription2,
                IDescription3 = obj.IDescription3,
                IDescription4 = obj.IDescription4,
                IDescription5 = obj.IDescription5,
                IDate1 = obj.IDate1,
                IDate2 = obj.IDate2,
                IDate3 = obj.IDate3,
                IDate4 = obj.IDate4,
                IDate5 = obj.IDate5,
                IGDRG1 = obj.IGDRG1,
                IGDRG2 = obj.IGDRG2,
                IGDRG3 = obj.IGDRG3,
                IGDRG4 = obj.IGDRG4,
                IGDRG5 = obj.IGDRG5,
                TUNIT = obj.TUNIT,
                ClaimsStatus = obj.ClaimsStatus













            };
        }
    }
}
