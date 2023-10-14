using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceApp
{
    interface IAccount
    {
        void BankAccount();
    }

    interface ICredited
    {
        void AmountCredited(int amount);
    }

    class CheckAccount : IAccount, ICredited
    {
        public void BankAccount()
        {
            Console.WriteLine("I  am the checking account");
        }
        public void AmountCredited(int amount)
        {
            Console.WriteLine("An amount of ${0} transferred to your account", amount);
        }
        public void Savings()
        {
            Console.WriteLine("I am the savings account");
        }
    }
}