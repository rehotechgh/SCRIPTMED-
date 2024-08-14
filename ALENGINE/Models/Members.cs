using System.ComponentModel.DataAnnotations.Schema;

namespace ALENGINE.Models
{
    public class Members
    {
        public int Id { get; set; }
        public string? PID { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Gender { get; set; }
        public string? Blood_Group { get; set; }
        public string? Address_Line1 { get; set; }
        public string? Address_Line2 { get; set; }
        public string? Location { get; set; }
        public string? Contact_Number { get; set; }
        public string? Next_of_Kin { get; set; }
        public string? Next_of_Kin_contact { get; set; }
        public string? Location_Next_of_Kin { get; set; }
        public double? Amount { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now.Date;


        


    }
}
