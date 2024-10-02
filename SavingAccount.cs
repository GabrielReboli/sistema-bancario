using System; 
using System.Collections.Generic;

public class SavingsAccount : Account
{
    public double Rate { get; set; }
    private int withdrawalCount = 0;

    public SavingsAccount(int accNumber, double balance, DateTime openingDate, double rate)
        : base(accNumber, balance, openingDate)
    {
        Rate = rate;
    }

    public override void DebitAmount(double amount)
    {
        if (Balance >= amount)
        {
            if (withdrawalCount >= 3)
            {
                Balance -= (amount + 1.00); // Taxa de serviço de R$1,00
            }
            else
            {
                Balance -= amount;
            }
            withdrawalCount++;
        }
        else
        {
            throw new InvalidOperationException("Saldo insuficiente.");
        }
    }

    public void ApplyInterest() => Balance += Balance * Rate;

    protected override bool CanTransfer(double amount)
    {
        return Balance >= amount && amount >= 0; // Modificar a lógica conforme necessário
    }

    public override void FazerPix(double amount)
    {
        throw new NotSupportedException("Conta Poupança não suporta FazerPix.");
    }
}
