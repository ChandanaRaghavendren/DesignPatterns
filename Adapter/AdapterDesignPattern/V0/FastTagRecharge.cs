using System;
using System.Collections.Generic;
using System.Text;
using AdapterDesignPattern.V0.BankAPIs;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdapterDesignPattern.V0
{
    public class FastTagRecharge
    {
        public bool recharge(int amount, YesBankAPI yesBankAPI)
        {
            if (yesBankAPI.getBalance() > amount)
            {
                Console.WriteLine("Successful!");
                return true;
            }
            return false;
        }
    }
}
