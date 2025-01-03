﻿using System;
namespace ALENGINE.Models.ViewModel
{
	public class ConsultingViewModel
    {
        public int Id { get; set; }
        public string? RegistrationNumber { get; set; }
        public string? FacilityNo { get; set; }
        public string? PatientType { get; set; }
        public string? RequestingPhysician { get; set; }
        public string? RequestPreparedBy { get; set; }
        public string? ClinicalDiagnoses { get; set; }
        public string? LabRequestDetails { get; set; }
        public string? Surname { get; set; }
        public string? OtherNames { get; set; }
        public string? Weight { get; set; }
        public string? BloodGroup { get; set; }
        public string? BloodPressure { get; set; }
        public string? Examination { get; set; }
        public string? Treatment { get; set; }
        public string? Request { get; set; }
        public string? LabType { get; set; }
        public string? LabResult { get; set; }
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
        public string? Diagnosis5 { get; set; }
        public string? Diagnosis6 { get; set; }
        public string? DiagnosisCategory1 { get; set; }
        public string? DiagnosisCategory2 { get; set; }
        public string? DiagnosisCategory3 { get; set; }
        public string? DiagnosisCategory4 { get; set; }
        public string? DiagnosisCategory5 { get; set; }
        public string? DiagnosisCategory6 { get; set; }

        public string? DDescription1 { get; set; }
        public string? DDescription2 { get; set; }
        public string? DDescription3 { get; set; }
        public string? DDescription4 { get; set; }
        public string? DICD1 { get; set; }
        public string? DICD2 { get; set; }
        public string? DICD3 { get; set; }
        public string? DICD4 { get; set; }
        public string? DICD5 { get; set; }
        public string? DICD6 { get; set; }
        public string? DIDRG1 { get; set; }
        public string? DIDRG2 { get; set; }
        public string? DIDRG3 { get; set; }
        public string? DIDRG4 { get; set; }
        public string? DIDRG5 { get; set; }
        public string? DIDRG6 { get; set; }
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
        public string? Temperature { get; set; }
        public string? HistoryIntake { get; set; }
        public int PatientInformationId { get; set; }


        public DateTime DateCreated { get; set; } = DateTime.Now;

        internal static ConsultingViewModel ViewInitData(VitalInfo? obj)
        {
            return new ConsultingViewModel
            {


                //show data
                RegistrationNumber = obj.RegistrationNumber,
                Surname = obj.Surname,
                OtherNames = obj.OtherNames,
                Weight = obj.Weight,
                Height = obj.Height,
                BloodPressure = obj.BloodPressure,
                Condition = obj.Condition,
                CCC = obj.CCC,
                Temperature = obj.Temperature,
                PatientInformationId = obj.PatientInformationId














            };
        }
    }
}

