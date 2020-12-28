using System;
using _07Heranca.Entities;

namespace _07Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1002, "Marcelo", 500.0);
            Account acc2 = new SavingAccount(1003, "Marcelo", 500.0, 0.01);

            acc1.WithDraw(10.0);
            acc2.WithDraw(10.0);

            Console.WriteLine($"Saque da conta Account = {acc1.Balance}");
            Console.WriteLine($"Saque da conta SavingAccount = {acc2.Balance}");
        }
    }
}
