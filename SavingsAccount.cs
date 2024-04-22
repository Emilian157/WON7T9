using System;

public class SavingsAccount : BankAccount
{
    private readonly double interestRate;

    public SavingsAccount(string ownerName, double interestRate) : base("Cont de economii", ownerName)
    {
        this.interestRate = interestRate;
    }

    public override void Deposit(decimal amount)
    {
        base.Deposit(amount);
        Balance *= (decimal)(1 + interestRate);
        Console.WriteLine($"Soldul contului de economii al lui {OwnerName} a fost reactualizat. Soldul curent: {Balance} RON.");
    }

    protected override string WithdrawMessage()
    {
        return "Retragerea nu este permisa pentru conturile de economii.";
    }
}