using System;

public class InvestmentAccount : BankAccount
{
    private readonly int withdrawalDay;
    private bool canWithdraw;

    public InvestmentAccount(string ownerName, int withdrawalDay) : base("Cont de investiții", ownerName)
    {
        this.withdrawalDay = withdrawalDay;
        canWithdraw = false;
    }

    public override void Deposit(decimal amount)
    {
        base.Deposit(amount);
        Console.WriteLine($"S-a depus suma de {amount} RON în contul de investiții al lui {OwnerName}. Soldul curent: {Balance} RON.");
    }

    public override void Withdraw(decimal amount)
    {
        if (canWithdraw)
        {
            base.Withdraw(amount);
        }
        else
        {
            Console.WriteLine($"Retragerea nu este permisă pentru contul de investiții al lui {OwnerName} înainte de ziua de retragere ({withdrawalDay}).");
        }
    }

    public override string Description()
    {
        return base.Description() + $"\nZiua termenului de extragere: {withdrawalDay}";
    }

    public void CheckWithdrawalEligibility()
    {
        canWithdraw = DateTime.Now.Day >= withdrawalDay;
    }

    protected override string WithdrawMessage()
    {
        return "Retragerea nu este permisă pentru conturile de investiții.";
    }
}