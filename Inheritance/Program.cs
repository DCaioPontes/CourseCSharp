using System;
using Inheritance.Entities;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Caio Pontes", 8000);
            BussinesAccount bacc = new BussinesAccount(1002, "Maria", 0, 500);

            // upcasting

            Account acc1 = bacc;
            Account acc2 = new BussinesAccount(1003, "Bob", 00, 1000);
            Account acc3 = new SavingsAccount(1006, "anna", 00, 2);

            // dawnCasting

            BussinesAccount acc4 = (BussinesAccount)acc2;
            acc4.Loan(100.0);

            // BussinesAccount acc5 = (BussinesAccount)acc3;

            if (acc3 is BussinesAccount)
            {
                //BussinesAccount acc5 = (BussinesAccount)acc3;
                
                BussinesAccount acc5 = acc3 as BussinesAccount;
                acc5.Loan(200);
                Console.WriteLine("Bommm!");
            }
        }
    }
}