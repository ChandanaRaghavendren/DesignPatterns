using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPattern.v1
{
    public interface BankAPI
    {
        public int checkBalance();
        public void transferMoney(int amount);
    }
}
