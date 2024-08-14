using System;
namespace ALENGINE.Models.ViewModel
{
	public class DispensaryViewModel
	{
        public int Id { get; set; }
        public string? RegistrationNumber { get; set; }
        public string? Surname { get; set; }
        public string? OtherNames { get; set; }
        public string? Examination { get; set; }
        public string? Treatment { get; set; }
        public string? ItemName { get; set; }
        public string? ManufacturingDate { get; set; }
        public string? ExpiryDate { get; set; }
        public string? Manufacturer { get; set; }
        public int Quantity { get; set; }
        public double CostPrice { get; set; }
        public double SalesPrice { get; set; }
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
        public DateTime CreatedDate { get; set; } = DateTime.Now.Date;

          internal static DispensaryViewModel ViewDispenseryData(Central? initpayment)
        {
            return new DispensaryViewModel
            {


                //show data
                RegistrationNumber = initpayment.RegistrationNumber,
                Surname = initpayment.Surname,
                OtherNames = initpayment.OtherNames,
                TypeOfService = initpayment.DispensaryType,
                Outcome = initpayment.Outcome,
                VisitationType = initpayment.VisitationType,
                VisitationDate = initpayment.VisitationType,
                Procedure1 = initpayment.Procedure1,
                Procedure2 = initpayment.Procedure2,
                Procedure3 = initpayment.Procedure3,
                PDescription1 = initpayment.PDescription1,
                PDescription2 = initpayment.PDescription2,
                PDescription3 = initpayment.PDescription3,
                Pdate1 = initpayment.Pdate1,
                Pdate2 = initpayment.Pdate2,
                Pdate3 = initpayment.Pdate3,
                PDRG1 = initpayment.PDRG1,
                PDRG2 = initpayment.PDRG2,
                PDRG3 = initpayment.PDRG3,
                Diagnosis1 = initpayment.Diagnosis1,
                Diagnosis2 = initpayment.Diagnosis2,
                Diagnosis3 = initpayment.Diagnosis3,
                Diagnosis4 = initpayment.Diagnosis4,
                DDescription1 = initpayment.DDescription1,
                DDescription2 = initpayment.DDescription2,
                DDescription3 = initpayment.DDescription3,
                DDescription4 = initpayment.DDescription4,
                DICD1 = initpayment.DICD1,
                DICD2 = initpayment.DICD2,
                DICD3 = initpayment.DICD3,
                DICD4 = initpayment.DICD4,
                DIDRG1 = initpayment.DIDRG1,
                DIDRG2 = initpayment.DIDRG2,
                DIDRG3 = initpayment.DIDRG3,
                DIDRG4 = initpayment.DIDRG4,
                Investigation1 = initpayment.Investigation1,
                Investigation2 = initpayment.Investigation2,
                Investigation3 = initpayment.Investigation3,
                Investigation4 = initpayment.Investigation4,
                Investigation5 = initpayment.Investigation5,
                IDescription1 = initpayment.IDescription1,
                IDescription2 = initpayment.IDescription2,
                IDescription3 = initpayment.IDescription3,
                IDescription4 = initpayment.IDescription4,
                IDescription5 = initpayment.IDescription5,
                IDate1 = initpayment.IDate1,
                IDate2 = initpayment.IDate2,
                IDate3 = initpayment.IDate3,
                IDate4 = initpayment.IDate4,
                IDate5 = initpayment.IDate5,
                IGDRG1 = initpayment.IGDRG1,
                IGDRG2 = initpayment.IGDRG2,
                IGDRG3 = initpayment.IGDRG3,
                IGDRG4 = initpayment.IGDRG4,
                IGDRG5 = initpayment.IGDRG5














            };
        }
    }
}

