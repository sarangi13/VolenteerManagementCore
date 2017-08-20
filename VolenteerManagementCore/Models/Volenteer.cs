using System.ComponentModel.DataAnnotations;

namespace VolenteerManagementCore.Models
{
    public class Volenteer
    {
        [Key]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Center { get; set; }
        public string Skills { get; set; }
        public int Availalibity { get; set; }
        public string Address { get; set; }
        public long Phone { get; set; }
        public string Email { get; set; }
        public string Education { get; set; }
        public string Lincense { get; set; }
        public string EmergencyContact { get; set; }
        public long EmergencyPhone { get; set; }
        public string EmergencyEmail { get; set; }
        public string EmergencyAddress { get; set; }
        public bool Drivers { get; set; }
        public bool Ssn { get; set; }
        public string ApprovalStatus { get; set; }
    }
}
