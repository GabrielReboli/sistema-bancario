# Sistema Bancário com Padrão Factory Method

Este projeto implementa um sistema bancário simples utilizando o padrão de projeto **Factory Method** em C#. O sistema permite a criação de diferentes tipos de contas bancárias (conta corrente, poupança e salário), além de operações básicas como saque, depósito, transferência, e gerenciamento de clientes e agências.

## Estrutura do Projeto

O projeto segue uma arquitetura de classes orientadas a objetos. As principais classes são:

- **Bank**: Gerencia clientes e agências.
- **Branch**: Gerencia contas de clientes.
- **Client**: Representa um cliente com informações pessoais.
- **Account**: Classe abstrata que define as operações comuns para contas bancárias.
  - **CurrentAccount**: Conta corrente com taxa de serviço e limite.
  - **SavingsAccount**: Conta poupança com limite de saques gratuitos e taxa de juros.
  - **SalaryAccount**: Conta salário, com funcionalidades limitadas.
  
## Padrão de Projeto Aplicado

O padrão **Factory Method** é utilizado para a criação das contas bancárias. Ele permite a criação flexível de novas contas, sem modificar o código cliente. As fábricas responsáveis pela criação de contas são:

- **CurrentAccountFactory**: Cria instâncias de contas correntes.
- **SavingsAccountFactory**: Cria instâncias de contas poupança.
- **SalaryAccountFactory**: Cria instâncias de contas salário.

### Vantagens do Factory Method:
- **Extensibilidade**: Novos tipos de contas podem ser adicionados facilmente, criando novas fábricas.
- **Manutenção**: A lógica de criação de contas está separada do código principal, facilitando a manutenção e a evolução do sistema.


