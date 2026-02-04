using System;
using System.Collections.Generic;
using System.Text;
using AdapterDesignPattern.V0.BankAPIs;

namespace AdapterDesignPattern.v1.BankAPIAdapter
{
    public class YesBankAPIAdapter : BankAPI
    {
        private YesBankAPI yesBankAPI = new YesBankAPI();

        public int checkBalance()
        {
            return yesBankAPI.getBalance();
        }


        public void transferMoney(int amount)
        {
            yesBankAPI.transfer(amount);
        }
    }
}
