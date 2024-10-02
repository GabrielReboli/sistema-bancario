using System;


public class CurrentAccountFactory : IAccountFactory
{
    public Account CreateAccount(int accNumber, double balance, DateTime openingDate, params object[] parameters)
    {
        if (parameters.Length != 2)
            throw new ArgumentException("Número incorreto de parâmetros.");

        double serviceFee = Convert.ToDouble(parameters[0]);
        double limit = Convert.ToDouble(parameters[1]);
        return new CurrentAccount(accNumber, balance, openingDate, serviceFee, limit);
    }
}
