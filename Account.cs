using System; 
using System.Collections.Generic;

public abstract class Account
{
    public int AccNumber { get; set; }
    public double Balance { get; protected set; }
    public DateTime OpeningDate { get; set; }

    protected Account(int accNumber, double balance, DateTime openingDate)
    {
        AccNumber = accNumber;
        Balance = balance;
        OpeningDate = openingDate;
    }

    public abstract void DebitAmount(double amount);
    public void CreditAmount(double amount) => Balance += amount;
    public double GetBalance() => Balance;
    public void Transfer(Account account, double amount)
    {
        if (CanTransfer(amount))
        {
            DebitAmount(amount);
            account.CreditAmount(amount);
        }
        else
        {
            throw new InvalidOperationException("Não é possível transferir o valor.");
        }
    }

    protected virtual bool CanTransfer(double amount) => Balance >= amount;
    public virtual void FazerPix(double amount) => throw new NotSupportedException("FazerPix não é suportado para esta conta.");
}
