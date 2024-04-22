using System;

public class CurrentAccount : BankAccount
{
    private const decimal OverdraftLimit = 5000;

    public CurrentAccount(string ownerName) : base("Cont curent", ownerName)
    {
    }

    public override void Withdraw(decimal amount)
    {
        if (amount <= Balance + OverdraftLimit)
        {
            Balance -= amount;
            Console.WriteLine($"S-a retras suma de {amount} RON din contul curent al lui {OwnerName}. Soldul curent: {Balance} RON.");
        }
        else
        {
            Console.WriteLine($"Suma cerută depășește plafonul de descoperire de cont pentru {OwnerName}. Suma nu poate fi retrasă.");
        }
    }

    protected override string WithdrawMessage()
    {
        return "Retragerea nu este permisă pentru conturile curente.";
    }
}