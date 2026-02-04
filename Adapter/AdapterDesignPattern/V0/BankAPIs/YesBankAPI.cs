using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPattern.V0.BankAPIs
{
    public class YesBankAPI
    {
        public int getBalance()
        {
            Console.WriteLine("Yes Bank is checking the balance");
            return 100;
        }

        public void transfer(int amount)
        {
            Console.WriteLine("Money has been transferred via Yes Bank");
        }
    }
}
