using System; 
using System.Collections.Generic;

public class SavingsAccountFactory : IAccountFactory
{
    public Account CreateAccount(int accNumber, double balance, DateTime openingDate, params object[] parameters)
    {
        double rate = (double)parameters[0];
        return new SavingsAccount(accNumber, balance, openingDate, rate);
    }
}
