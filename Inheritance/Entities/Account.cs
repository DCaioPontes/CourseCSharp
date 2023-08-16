namespace Inheritance.Entities;

public class Account
{
    public int Number { get; private set; }
    public string Holder { get; private set; }
    public double Balance { get; protected set; }

    public Account()
    {
    }

    public Account(int number, string holder, double balance)
    {
        Number = number;
        Holder = holder;
        Balance = balance;
    }

    public virtual void Withdraw(double amount)
    {
        if (Balance >= amount + 5)
        {
            Balance -= amount +5;
        }

        else
        {
            Console.WriteLine("Saldo insuficiente :(");
        }
        
    }

    public void Deposit(double amount)
    {
        Balance += amount;
    }
}