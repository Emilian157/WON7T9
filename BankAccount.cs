using System;

public abstract class BankAccount
{
    public Guid Id { get; }
    public string AccountType { get; }
    public string OwnerName { get; protected set; }
    protected decimal Balance { get; set; }

    public BankAccount(string accountType, string ownerName)
    {
        Id = Guid.NewGuid();
        AccountType = accountType;
        OwnerName = ownerName;
        Balance = 0;
    }

    public virtual void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"S-a depus suma de {amount} RON în contul lui {OwnerName}. Soldul curent: {Balance} RON.");
    }

    public virtual void Withdraw(decimal amount)
    {
        Console.WriteLine($"Incercare de retragere a sumei de {amount} RON din contul lui {OwnerName}.");
        Console.WriteLine(WithdrawMessage());
    }

    public virtual string Description()
    {
        return $"Id: {Id}\nTip cont: {AccountType}\nNume proprietar: {OwnerName}\nSold curent: {Balance} RON";
    }

    protected abstract string WithdrawMessage();
}