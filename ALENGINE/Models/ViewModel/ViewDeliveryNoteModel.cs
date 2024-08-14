using System;
namespace ALENGINE.Models.ViewModel
{
	public class ViewDeliveryNoteModel
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
        public DateTime DateCreated { get; set; } = DateTime.Now;

        internal static ViewDeliveryNoteModel ViewDelivery(DeliveryNote? obj)
        {
            return new ViewDeliveryNoteModel
            {


                //show data
                RegistrationNumber = obj.RegistrationNumber,
                Surname = obj.Surname,
                OtherNames = obj.OtherNames,
                DOB = obj.DOB,
                Age = obj.Age,
                Sex = obj.Sex












            };
        }
    }
}

