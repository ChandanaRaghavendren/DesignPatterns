using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdapterDesignPattern.v1
{
    public class FastTagRechargeV1
    {
        public bool recharge(int amount, BankAPI bankAPI)
        {
            if (bankAPI.checkBalance() > amount)
            {
                Console.WriteLine("Successful!");
                return true;
            }
            return false;
        }
    }
}
