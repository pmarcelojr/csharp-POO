using _11ExcecoesPersonalizadas2.Entities.Exceptions;
using System;

namespace _11ExcecoesPersonalizadas2.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account() { }
        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if(amount > WithDrawLimit)
                throw new DomainException("WithDraw Error: The amount exceeds withdraw limit");
            else if ((Balance -= amount) <= 0)
                throw new DomainException("WithDraw Error: Not enough balance");
            else
                Balance -= amount;
        }

        public override string ToString()
        {
            return $"New Balance {Balance}";
        }
    }
}