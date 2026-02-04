using System;
using System.Collections.Generic;
using System.Text;
using AdapterDesignPattern.V0.BankAPIs;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdapterDesignPattern.V0
{
    public class PhonePeLoan
    {
        public bool checkLoanEligibility(int amount, YesBankAPI yesBankAPI)
        {
            // Loan will be given if you have 10% of the loan amount in your bank
            if (yesBankAPI.getBalance() >= .1 * amount)
            {
                Console.WriteLine("Loan can be given!");
                return true;
            }
            return false;
        }
    }
}
