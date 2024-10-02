using System; 
using System.Collections.Generic;

public class SalaryAccountFactory : IAccountFactory
{
    public Account CreateAccount(int accNumber, double balance, DateTime openingDate, params object[] parameters)
    {
        return new SalaryAccount(accNumber, balance, openingDate);
    }
}
