namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        // Create a bank account object
        BankAccount myAccount = new BankAccount("ACC12345", 5000);

        // Display account number
        Console.WriteLine("Account Number: " + myAccount.AccountNumber);
        Console.WriteLine("Initial Balance: " + myAccount.Balance);

        // Deposit money
        myAccount.Deposit(1500);

        // Withdraw money
        myAccount.Withdraw(1200);

        // Display final balance
        Console.WriteLine("Remaining Balance: " + myAccount.Balance);

        Console.ReadLine();
    }
}