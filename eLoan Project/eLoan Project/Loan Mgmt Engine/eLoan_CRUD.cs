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
        /*Parameters from the form to be place in database fields follow this convention: fieldname1=xxxx, fieldname2=yyyyyy, etc.*/
        public static Address GatherAddressForm(/*add params as necessary*/)
        {
            var AddressForm = new Address {/*Parameters from the form to be place in database fields*/ };
            //code
            return AddressForm;
        }
        public static Application GatherApplicationForm(/*add params as necessary*/)
        {
            var ApplciationForm = new Application {/*Parameters from the form to be place in database fields*/};
            //code
            return ApplciationForm;
        }
        public static Profile GatherProfileForm(/*add params as necessary*/)
        {
            var ProfileForm = new Profile {/*Parameters from the form to be place in database fields*/};
            //code
            return ProfileForm;
        }
        public static Login GatherLoginForm(/*add params as necessary*/)
        {
            var LoginForm = new Login {/*Parameters from the form to be place in database fields*/};
            //code
            return LoginForm;
        }

        #region Create Database Entity
        public static void createAddressEntry(eLoanContext context, Address address)
        {
            context.Database.EnsureCreated();
            context.Add(address);
            context.SaveChanges();
        }
        public static void createApplicationEntry(eLoanContext context, Application application)
        {
            context.Database.EnsureCreated();
            context.applications.Add(application);
            context.SaveChanges();
        }
        public static void createBankEntry(eLoanContext context, Bank bank)
        {
            context.Database.EnsureCreated();
            context.banks.Add(bank);
            context.SaveChanges();
        }
        public static void createCustomerEntry(eLoanContext context, Customer customer)
        {
            context.Database.EnsureCreated();
            context.customers.Add(customer);
            context.SaveChanges();
        }
        public static void createLoanEntry(eLoanContext context, Loan loan)
        {
            context.Database.EnsureCreated();
            context.loans.Add(loan);
            context.SaveChanges();
        }
        public static void createLoginEntry(eLoanContext context, Login login)
        {
            context.Database.EnsureCreated();
            context.logins.Add(login);
            context.SaveChanges();
        }
        public static void createProfileEntry(eLoanContext context, Profile profile)
        {
            context.Database.EnsureCreated();
            context.profiles.Add(profile);
            context.SaveChanges();
        }

        #endregion

        #region Read Database Data
        public static Address ReadAddressData(eLoanContext context, int key)
        {
            return context.addresses.Find(key);
        }
        public static Application ReadApplicationData(eLoanContext context, int key, int foreignKey)
        {
            return context.applications.Find(key, foreignKey);
        }
        public static Bank ReadBankData(eLoanContext context, int key, int foreignKey)
        {
            return context.banks.Find(key, foreignKey);
        }
        public static Customer ReadCustomerData(eLoanContext context, int key, int foreignKey1, int foreignKey2, int foreignKey3)
        {
            return context.customers.Find(key, foreignKey1, foreignKey2, foreignKey3);
        }
        public static Loan ReadLoanData(eLoanContext context, int key)
        {
            return context.loans.Find(key);
        }
        public static Login ReadLoginData(eLoanContext context, int key, int foreignKey)
        {
            return context.logins.Find(key, foreignKey);
        }
        public static Profile ReadProfileData(eLoanContext context, int key, int foreignKey)
        {
            return context.profiles.Find(key, foreignKey);
        }

        #endregion

        #region Update Datatbase Data
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

        #endregion

        //Delete maybe

    }
}
