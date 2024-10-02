using System; 
using System.Collections.Generic;

public interface IAccountFactory
{
    Account CreateAccount(int accNumber, double balance, DateTime openingDate, params object[] parameters);
}
