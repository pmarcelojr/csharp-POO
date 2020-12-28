﻿using System;
using System.Globalization;
using System.Collections.Generic;
using _07Heranca.Entities;

namespace _07Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();

            list.Add(new SavingAccount(1001, "Alex", 500.00, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.00, 400.00));
            list.Add(new SavingAccount(1003, "Bob", 500.00, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.00));

            double sum = 0.0;
            foreach(Account acc in list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine($"Total Balance> {sum.ToString("F2", CultureInfo.InvariantCulture)}");

            foreach(Account acc in list)
            {
                acc.WithDraw(10.0);
            }
            foreach(Account acc in list)
            {
                Console.WriteLine($"Updated balance for account {acc.Number}: {acc.Balance.ToString("f2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
