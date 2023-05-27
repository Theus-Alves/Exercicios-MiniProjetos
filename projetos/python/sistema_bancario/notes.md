**Relatório: Programa de Sistema Bancário**

**Objetivo:**
O objetivo deste programa é simular um sistema bancário básico com validação de erros, permitindo ao usuário realizar operações como depósito, saque e visualização do extrato de uma conta bancária fictícia.

**Introdução:**
O programa foi desenvolvido como uma aplicação de console em Python para fornecer funcionalidades bancárias essenciais. Ele oferece uma interação simples com o usuário, permitindo que ele escolha as opções desejadas e realize as operações bancárias correspondentes.

**Métodos:**
1. `SistemaBancario`: Classe responsável por gerenciar o sistema bancário.
   - `__init__(self, saldo)`: Inicializa o objeto SistemaBancario com saldo inicial, listas de depósitos e saques.
   - `deposito(self, valor)`: Realiza um depósito na conta bancária.
   - `saque(self, valor)`: Realiza um saque na conta bancária.
   - `extrato(self)`: Exibe o extrato da conta bancária.

2. `obter_saldo()`: Solicita ao usuário o saldo fictício da conta bancária.

3. `menu()`: Função que exibe o menu de opções e permite ao usuário interagir com o sistema bancário.

**Resultados:**
O programa oferece ao usuário uma experiência interativa, permitindo que ele escolha as opções desejadas e realize as operações bancárias correspondentes. Ele exibe mensagens informativas para cada operação realizada, como depósito, saque e exibição do extrato. O usuário pode repetir as operações quantas vezes desejar antes de sair do programa.

**Conclusão:**
O programa de Sistema Bancário desenvolvido é uma aplicação simples, mas funcional, que permite ao usuário realizar operações bancárias básicas em uma conta fictícia. Ele demonstra o uso de classes, métodos e interações com o usuário em Python. Embora seja um projeto acadêmico, ele pode servir como uma base para o desenvolvimento de um sistema bancário mais completo e robusto.