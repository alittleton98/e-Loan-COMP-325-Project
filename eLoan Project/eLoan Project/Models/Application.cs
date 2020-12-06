using System;
namespace eLoan_Project.Models
{
    public class Application
    {
        //Added a couple of loan states to encompass the application process as well
        //public enum LOAN_STATE
        //{
        //    APP_SUBMITTED,
        //    APPROVED,
        //    IN_PROGRESS,
        //    FINISHED
        //}

        
        public int application_ID { get; set; }
        public int profile_ID { get; set; }
        public int last4ssn { get; set; }
        public string loanState { get; set; }
        //made an array so that first and last name can be passed without parsing 
        //employee_name[0] = profile.first_name, employee_name[1] = profile.last_name, employee_name[2] = profile.middle_initial
        public string employee_name { get; set; } 
        public float monthly_salary { get; set; }
        public float rent_mortgage_expense { get; set; }
        public float additional_expense { get; set; }
        public float amount_requested { get; set; }
        public int tenure_in_months { get; set; } //in months
        public DateTime application_date { get; set; }
        public Application()
        {
        }
    }
}
