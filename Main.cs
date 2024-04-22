using System;

class Program
{
    static void Main(string[] args)
    {
        //Exercitul I

        BankAccount account1 = new CurrentAccount("Mihai Ungureanu");
        account1.Deposit(2000);
        account1.Withdraw(1500);
        account1.Withdraw(4000);

        Console.WriteLine();

        BankAccount account2 = new SavingsAccount("Marin Alexandru", 0.07);
        account2.Deposit(5000);
        account2.Withdraw(2000);

        Console.WriteLine();

        //Exercitiul II

        BankAccount account3 = new InvestmentAccount("Lica Samadau", 15);
        account3.Deposit(10000);
        ((InvestmentAccount)account3).CheckWithdrawalEligibility();
        account3.Withdraw(5000);

        Console.WriteLine();

        Console.WriteLine(account1.Description());
        Console.WriteLine();
        Console.WriteLine(account2.Description());
        Console.WriteLine();
        Console.WriteLine(account3.Description());
    }
}