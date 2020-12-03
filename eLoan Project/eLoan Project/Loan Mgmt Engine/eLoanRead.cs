using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eLoan_Project.Data;
using eLoan_Project.Models;
using static eLoan_Project.Loan_Mgmt_Engine.FieldCountConstants;

namespace eLoan_Project.Loan_Mgmt_Engine
{
    /*
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
    */

    //Class is primarily for reading from the view forms. The eLoan_Write class will handle the information once it is read

    public class eLoanRead
    {
        public static Address[] ReadAddressForm()
        {
            Address[] UserAddressInformation = new Address[AddressFieldCount];

            //Enter fields from view form here. Elements in array correspond to fields in database order

            return UserAddressInformation;
        }
        public static Address[] ReadApplicationForm()
        {
            Address[] UserApplicationInformation = new Address[AddressFieldCount];

            //Enter fields from view form here. Elements in array correspond to fields in database order

            return UserAddressInformation;
        }
    }
}
