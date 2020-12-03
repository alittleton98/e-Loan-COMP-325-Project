using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using eLoan_Project.Data;
using eLoan_Project.Models;
using System.Diagnostics;

namespace eLoan_Project.LoanMgmtEngine
{
    public class DecisionMakingScript
    {
        private int application_id;
   

        public DecisionMakingScript(int ApplicationId)
        {
            application_id = ApplicationId;
        }

        public double rent_morgage(eLoanContext context, Application application)
        {
            return 10.01;
        }

        public double monthly_salary(eLoanContext context, Application application)
        {
            return 100;
        }

        public double additional_expense(eLoanContext context, Application application)
        {
            return 1.1;
        }

        public double amount_requested(eLoanContext context, Application application)
        {
            return 20.1;
        }

        public int tenure_in_months(eLoanContext context, Application application)
        {
            return 24;
        }

        public Boolean decision(eLoanContext context)
        {
            return true;
        }

        public double loan_amount(eLoanContext context)
        {
            return 60.00;
        }

        public double interest_rate(eLoanContext context)
        {
            return 5.1;
        }
    }
}
