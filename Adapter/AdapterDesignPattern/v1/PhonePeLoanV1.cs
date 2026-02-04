using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdapterDesignPattern.v1
{
    public class PhonePeLoanV1
    {
        public bool checkLoanEligibility(int amount, BankAPI bankAPI)
        {
            // Loan will be given if you have 10% of the loan amount in your bank
            if (bankAPI.checkBalance() >= .1 * amount)
            {
                Console.WriteLine("Loan can be given!");
                return true;
            }
            return false;
        }
    }
}
