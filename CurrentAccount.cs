using System; 
using System.Collections.Generic;

public class CurrentAccount : Account
{
    public double ServiceFee { get; set; }
    public double Limit { get; set; }

    public CurrentAccount(int accNumber, double balance, DateTime openingDate, double serviceFee, double limit)
        : base(accNumber, balance, openingDate)
    {
        ServiceFee = serviceFee;
        Limit = limit;
    }

    public override void DebitAmount(double amount)
    {
        if (Balance + Limit >= amount)
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
        // Implementar lógica de fazer Pix
    }
}
