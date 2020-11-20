using System;
namespace eLoan_Project.Models
{
    public class Profile
    {
        public int profile_ID { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public DateTime birthdate { get; set; }
        public int address_ID { get; set; }
        public string phone_number { get; set; }
        public Profile()
        {
        }
    }
}
