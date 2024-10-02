using System; 
using System.Collections.Generic;

public class SalaryAccount : Account
{
    public SalaryAccount(int accNumber, double balance, DateTime openingDate)
        : base(accNumber, balance, openingDate)
    {
    }

    public override void DebitAmount(double amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
        }
        else
        {
            throw new InvalidOperationException("Saldo insuficiente.");
        }
    }

    public override void FazerPix(double amount)
    {
        throw new NotSupportedException("Conta Salário não suporta FazerPix.");
    }
}
