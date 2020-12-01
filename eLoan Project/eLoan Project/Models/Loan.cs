using System;
namespace eLoan_Project.Models
{
    public class Loan
    {
        public int loan_ID { get; set; }
        public float loan_amount { get; set; }
        public float balance_remaining { get; set; }
        public float interest_rate { get; set; }
        public int tenure_length { get; set; } //in months
        public DateTime loan_date { get; set; }


        public Loan()
        {
        }
    }
}
