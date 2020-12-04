using System;
namespace eLoan_Project.Models
{
    public class Address
    {
        
        public int address_ID { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string zipCode { get; set; }

        public Address()
        {
        }
    }
}
