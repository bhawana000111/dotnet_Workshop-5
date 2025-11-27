namespace Task1;

public class BankAccount
{
    private string accountNumber;
    private double balance;

    public string AccountNumber
    {
        get { return accountNumber; }
    }

    public double Balance
    {
        get { return balance; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Balance cannot be zero or negative.");
            }
            balance = value;
        }
    }

    // Constructor
    public BankAccount(string accNumber, double initialBalance)
    {
        accountNumber = accNumber;

        if (initialBalance <= 0)
        {
            throw new ArgumentException("Initial balance must be greater than zero.");
        }

        balance = initialBalance;
    }

    // Deposit method
    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount must be greater than zero.");
            return;
        }

        balance += amount;
        Console.WriteLine($"Successfully deposited {amount}. New balance: {balance}");
    }

    // Withdraw method
    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdraw amount must be greater than zero.");
            return;
        }

        if (amount > balance)
        {
            Console.WriteLine("Insufficient balance to withdraw this amount.");
            return;
        }

        balance -= amount;
        Console.WriteLine($"Successfully withdrew {amount}. New balance: {balance}");
    }
}