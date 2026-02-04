using System;
using System.Collections.Generic;
using System.Text;
using AdapterDesignPattern.V0.BankAPIs;

namespace AdapterDesignPattern.v1.BankAPIAdapter
{
    public class ICICIBankAdapter : BankAPI
    {
        private ICICIBankAPIV1 iciciBankAPI = new ICICIBankAPIV1();

        public int checkBalance()
        {
            return iciciBankAPI.balanceCheckV1();
        }

        public void transferMoney(int amount)
        {
            iciciBankAPI.moneyTransferV1(amount);
        }


    }
}
