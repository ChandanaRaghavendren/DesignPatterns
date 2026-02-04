using System;
using System.Collections.Generic;
using System.Text;
using AdapterDesignPattern.V0.BankAPIs;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdapterDesignPattern.V0
{
    internal class PhonePe
    {
        private FastTagRecharge fastTagRecharge;
        private PhonePeLoan phonePeLoan;
        private YesBankAPI yesBankAPI;

        public PhonePe()
        {
            this.fastTagRecharge = new FastTagRecharge();
            this.phonePeLoan = new PhonePeLoan(); //no DI here
            this.yesBankAPI = new YesBankAPI();
        }

        public bool rechargeFastTag(int amount)
        {
            return fastTagRecharge.recharge(amount, yesBankAPI); //dependent on 3rd party API
        }

        public bool availLoan(int amount)
        {
            if (phonePeLoan.checkLoanEligibility(amount, yesBankAPI))
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
