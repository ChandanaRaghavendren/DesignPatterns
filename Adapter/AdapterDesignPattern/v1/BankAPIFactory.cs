using System;
using System.Collections.Generic;
using System.Text;
using AdapterDesignPattern.v1.BankAPIAdapter;

namespace AdapterDesignPattern.v1
{
    public class BankAPIFactory
    {
        public static BankAPI getBankAPIByName(String bankName)
        {
            BankAPI bankAPI = null;
            if (bankName.Equals("ICICI", StringComparison.InvariantCultureIgnoreCase))
            {
                bankAPI = new ICICIBankAdapter();
            }
            else if (bankName.Equals("YesBank", StringComparison.InvariantCultureIgnoreCase))
            {
                bankAPI = new YesBankAPIAdapter();
            }
            return bankAPI;
        }
    }
}
