using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPattern.V0.BankAPIs
{
    public class ICICIBankAPI
    {
        int balanceCheck()
        {
            Console.WriteLine("ICICI Bank is checking the balance");
            return 100;
        }

        void moneyTransfer(int amount)
        {
            Console.WriteLine("Money has been transferred via ICICI Bank");
        }
    }
}
