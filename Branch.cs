using System;
using System.Collections.Generic;
    
public class Branch
{
    public string Name { get; set; }
    public int Code { get; set; }
    public string City { get; set; }
    private List<Account> accounts = new List<Account>();

    public Branch(string name, int code, string city)
    {
        Name = name;
        Code = code;
        City = city;
    }

    public void AddAccount(Account account)
    {
        accounts.Add(account);
    }

    public void RemoveAccount(Account account)
    {
        accounts.Remove(account);
    }

    public Account GetAccount(int accNumber)
    {
        return accounts.Find(acc => acc.AccNumber == accNumber);
    }
}
