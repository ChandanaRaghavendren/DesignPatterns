using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPattern.V0.BankAPIs
{
    public class YesBankAPIV1
    {
        public int getBalanceV1()
        {
            Console.WriteLine("Yes Bank is checking the balance");
            return 100;
        }

        public void transferV1(int amount)
        {
            Console.WriteLine("Money has been transferred via Yes Bank");
        }
    }
}
