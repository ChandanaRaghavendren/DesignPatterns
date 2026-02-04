using System;
using System.Collections.Generic;
using System.Text;
using AdapterDesignPattern.V0;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdapterDesignPattern.v1
{
    public class PhonePeV1
    {
        private FastTagRechargeV1 fastTagRecharge;
        private PhonePeLoanV1 phonePeLoan;
        private BankAPI bankAPI;

        public PhonePeV1(BankAPI bankAPI)
        {
            this.fastTagRecharge = new FastTagRechargeV1();
            this.phonePeLoan = new PhonePeLoanV1();
            this.bankAPI = bankAPI;
        }

        public bool rechargeFastTag(int amount)
        {
            return fastTagRecharge.recharge(amount, bankAPI);
        }

        public bool availLoan(int amount)
        {
            if (phonePeLoan.checkLoanEligibility(amount, bankAPI))
            {
                Console.WriteLine("Let's disburse the loan");
                return true;
            }
            else
            {
                Console.WriteLine("Sorry, you don't have enough money");
            }
            return false;
        }
    }
}
