using System; 
using System.Collections.Generic;

public class Bank
{
    public string Name { get; set; }
    public int Code { get; set; }
    private List<Branch> branches = new List<Branch>();
    private List<Client> clients = new List<Client>();

    public Bank(string name, int code)
    {
        Name = name;
        Code = code;
    }

    public void AddBranch(Branch branch)
    {
        branches.Add(branch);
    }

    public void RemoveBranch(Branch branch)
    {
        branches.Remove(branch);
    }

    public Branch GetBranch(int code)
    {
        return branches.Find(br => br.Code == code);
    }

    public void AddClient(Client client)
    {
        clients.Add(client);
    }

    public Client GetClient(string cpf)
    {
        return clients.Find(cl => cl.CPF == cpf);
    }
}