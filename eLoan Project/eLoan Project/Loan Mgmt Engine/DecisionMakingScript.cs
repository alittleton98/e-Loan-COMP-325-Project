using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eLoan_Project.Data;
using eLoan_Project.Models;
using static eLoan_Project.Loan_Mgmt_Engine.eLoan_CRUD;

namespace eLoan_Project.LoanMgmtEngine
{
  public class DecisionMakingScript
  {
    private int application_id;
        private int profile_id;
    eLoanContext context;
        //private eLoanContext context;

    public DecisionMakingScript(int ApplicationId, eLoanContext context, int ProfileId)
    {
      application_id = ApplicationId;
      profile_id = ProfileId;
      Application application = ReadApplicationData(context, application_id, profile_id);

      //context = cxt;
    }

    
    //eLoanContext
    //eLoanContext tuple = context.applications.Find(application_id);
    //context.applications.Find(application_id);

    public double rent_morgage()
    {
      return tuple.rent_morgage_expense;
    }

    public double monthly_salary()
    {
      return tuple.monthly_salary;
    }

    public double additional_expense()
    {
      return tuple.additional_expense;
    }

    public double amount_requested()
    {
      return tuple.amount_requested;
    }

    public int tenure_in_months()
    {
      return tuple.tenure_in_months;
    }

    public Boolean decision()
    {
      double monthly_salary = this.monthly_salary();
      double rent_morgage = this.rent_morgage();
      double additional_expense = this.additional_expense();

      double total_expenses = rent_morgage + additional_expense;
      double monthly_savings = monthly_salary - total_expenses;
      
      // Returns false if total expense is higher than monthly salary
      if (monthly_savings < 0)
      {
        return false;
      }

            double expense_percentage = (total_expenses / monthly_salary) * 100;
      
      // Total expense in percentage should be lesser than 60.00
      if (expense_percentage <= 60.00)
      {
        return true; 
      }

      return false;
    }

    public double loan_amount()
    {
      double monthly_salary = this.monthly_salary();
      double rent_morgage = this.rent_morgage();
      double additional_expense = this.additional_expense();
      double amount_requested = this.amount_requested();
      double tenure = this.tenure_in_months();

      double total_expenses = rent_morgage + additional_expense;
      double monthly_savings = monthly_salary - total_expenses;
      
      // Total amount is 80% of monthly savings into tenure in months
      double amount_calulated = (monthly_savings * 8/10) * tenure;

      // If amount requested is higher than calculated, return acalculated
      // Else return the amount requested since the user's requested amount is lower than allowed amount.
      if (amount_requested > amount_calulated)
      {
        return amount_calulated;
      }
      else
      { 
        return amount_requested;
      }
    }

    public double interest_rate()
    {
      double monthly_salary = this.monthly_salary();
      double rent_morgage = this.rent_morgage();
      double additional_expense = this.additional_expense();

      double total_expenses = rent_morgage + additional_expense;
            double expense_percentage = (total_expenses / monthly_salary) * 100;

      // Interest Rate is expense_percentage/10 
      // Ie if expense_percentage compared to savings is 30% the interest rate will be 3
      // If expense_percentage is 55% of total income, the rate is higher 5.5%
      // In short: The more a user has saved the lesser the interest rate.
            return expense_percentage / 10;
    }
  }
}
