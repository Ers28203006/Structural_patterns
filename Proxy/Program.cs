using System;

namespace Proxy
{
    interface IBank
    {
        void CashGiving();
    }

    class Bank : IBank
    {
        public void CashGiving()
        {
            Console.WriteLine("Выдыча денег клиенту");
        }
    }

    class ATM : IBank
    {
        IBank _bank;
        public ATM(IBank bank)
        {
            _bank = bank;
        }
        public void CashGiving()
        {
            _bank.CashGiving();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IBank bank = new Bank();
            IBank atm = new ATM(bank);
            atm.CashGiving();
        }
    }
}
