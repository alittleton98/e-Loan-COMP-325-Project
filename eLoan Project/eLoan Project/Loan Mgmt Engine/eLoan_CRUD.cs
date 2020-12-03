using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eLoan_Project.Data;
using eLoan_Project.Models;
using static eLoan_Project.Loan_Mgmt_Engine.FieldCountConstants;

namespace eLoan_Project.Loan_Mgmt_Engine
{
    static class FieldCountConstants
    {
        public const int AddressFieldCount = 6;
        public const int ApplicationFieldCount = 11;
        public const int BankFieldCount = 6;
        public const int CustomerFieldCount = 4;
        public const int LoanFieldCount = 5;
        public const int LoginFieldCount = 3;
        public const int ProfileFieldCount = 6;
    }

    //Fulfills CRUD
    public class eLoan_CRUD
    {
        
        //Read view forms 

        public static void GatherAddressForm(/*add params as necessary*/)
        {
            //code
        }
        public static void GatherApplicationForm(/*add params as necessary*/)
        {
            //code
        }
        public static void GatherProfileForm(/*add params as necessary*/)
        {
            //code
        }
        public static void GatherLoginForm(/*add params as necessary*/)
        {
            //code
        }

        //Create 
        public static void createAddressEntry(eLoanContext context, Address[] address)
        {

        }
        public static void createApplicationEntry(eLoanContext context, Address[] address)
        {

        }
        public static void createBankEntry(eLoanContext context, Address[] address)
        {

        }
        public static void createCustomerEntry(eLoanContext context, Address[] address)
        {

        }
        public static void createLoanEntry(eLoanContext context, Address[] address)
        {

        }
        public static void createLoginEntry(eLoanContext context, Address[] address)
        {

        }
        public static void createProfileEntry(eLoanContext context, Address[] address)
        {

        }
        


        //Read Database Data
        public static void ReadAddressData(/*add params as necessary*/)
        {
            //code
        }
        public static void ReadApplicationData(/*add params as necessary*/)
        {
            //code
        }
        public static void ReadBankData(/*add params as necessary*/)
        {
            //code
        }
        public static void ReadCustomerData(/*add params as necessary*/)
        {
            //code
        }
        public static void ReadLoginData(/*add params as necessary*/)
        {
            //code
        }
        public static void ReadProfileData(/*add params as necessary*/)
        {
            //code
        }

        //Update Datatbase Data
        public static void UpdateAddressData(/*add params as necessary*/)
        {
            //code
        }
        public static void UpdateApplicationData(/*add params as necessary*/)
        {
            //code
        }
        public static void UpdateBankData(/*add params as necessary*/)
        {
            //code
        }
        public static void UpdateCustomerData(/*add params as necessary*/)
        {
            //code
        }
        public static void UpdateLoginData(/*add params as necessary*/)
        {
            //code
        }
        public static void UpdateProfileData(/*add params as necessary*/)
        {
            //code
        }

        //Delete maybe

    }
}
