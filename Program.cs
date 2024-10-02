using System;

class Program
{
    static void Main()
    {
        // Exemplo de uso
        Bank bank = new Bank("BancoDoBr", 123);
        Branch branch = new Branch("Central", 1, "CityX");
        bank.AddBranch(branch);

        Client client = new Client("12345678900", "João Silva", "123 Street", "555-1234", "joao@example.com");
        bank.AddClient(client);

        // Usando as fábricas para criar contas
        IAccountFactory currentAccountFactory = new CurrentAccountFactory();
        IAccountFactory savingsAccountFactory = new SavingsAccountFactory();
        IAccountFactory salaryAccountFactory = new SalaryAccountFactory();

        Account currentAccount = currentAccountFactory.CreateAccount(1001, 500, DateTime.Now, 15, 100);
        branch.AddAccount(currentAccount);

        Account savingsAccount = savingsAccountFactory.CreateAccount(1002, 200, DateTime.Now, 0.05);
        branch.AddAccount(savingsAccount);

        Account salaryAccount = salaryAccountFactory.CreateAccount(1003, 300, DateTime.Now);
        branch.AddAccount(salaryAccount);

        // Operações com as contas
        currentAccount.DebitAmount(50);
        Console.WriteLine("Saldo após débito na Conta Corrente: " + currentAccount.GetBalance());

        currentAccount.CreditAmount(100);
        Console.WriteLine("Saldo após crédito na Conta Corrente: " + currentAccount.GetBalance());

        // Tentativa de transferência
        savingsAccount.Transfer(currentAccount, 50);
        Console.WriteLine("Saldo da Conta Poupança após transferência: " + savingsAccount.GetBalance());
        Console.WriteLine("Saldo da Conta Corrente após transferência: " + currentAccount.GetBalance());

        // Tentativa de uso de Pix na Conta Salário
        try
        {
            salaryAccount.FazerPix(20);
        }
        catch (NotSupportedException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
