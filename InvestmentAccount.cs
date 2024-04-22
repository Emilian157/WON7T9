using System;

public class InvestmentAccount : BankAccount
{
    private readonly int withdrawalDay;
    private bool canWithdraw;

    public InvestmentAccount(string ownerName, int withdrawalDay) : base("Cont de investitii", ownerName)
    {
        this.withdrawalDay = withdrawalDay;
        canWithdraw = false;
    }

    public override void Deposit(decimal amount)
    {
        base.Deposit(amount);
        Console.WriteLine($"S-a depus suma de {amount} RON în contul de investitii al lui {OwnerName}. Soldul curent: {Balance} RON.");
    }

    public override void Withdraw(decimal amount)
    {
        if (canWithdraw)
        {
            base.Withdraw(amount);
        }
        else
        {
            Console.WriteLine($"Retragerea nu este permisa pentru contul de investitii al lui {OwnerName} înainte de ziua de retragere ({withdrawalDay}).");
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
        return "Retragerea nu este permisa pentru conturile de investitii.";
    }
}