using System; 
using System.Collections.Generic;

public class Client {

  public string CPF { get; set; }
  public string Name { get; set; }
  public string Adress { get; set; }
  public string Phone { get; set; }
  public string Email { get; set; }
  

  public Client(string cpf, string name, string adress, string phone, string email){

   CPF = cpf;
   Name = name;
   Adress = adress;
   Phone = phone;
   Email = email;
  }
}