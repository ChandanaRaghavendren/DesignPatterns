using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPattern.V0.BankAPIs
{
    public class ICICIBankAPIV1
    {
        public int balanceCheckV1()
        {
            Console.WriteLine("ICICI Bank is checking the balance");
            return 100;
        }

        public void moneyTransferV1(int amount)
        {
            Console.WriteLine("Money has been transferred via ICICI Bank");
        }
    }
}
