from time import sleep
import os

class SistemaBancario:
    """
    Classe responsável por gerenciar o sistema bancário.
    """

    def __init__(self, saldo):
        """
        Inicializa o objeto SistemaBancario."""

        self.saldo = saldo
        self.depositos = []
        self.saques = []
        self.primeiro_saldo = saldo
    
    def deposito(self, valor):
        """
        Realiza um depósito na conta bancária.
        """
        if valor > 0:
            self.saldo += valor
            self.depositos.append(valor)
            print("\n>> Depósito realizado com sucesso!")
        else:
            print("\n!! Valor inválido para depósito!")
    
    def saque(self, valor):
        """
        Realiza um saque na conta bancária.
        """
        if valor > 0 and valor <= 500 and len(self.saques) < 3:
            if self.saldo >= valor:
                self.saldo -= valor
                self.saques.append(valor)
                print("\n>> Saque realizado com sucesso!")
            else:
                print("\n!! Saldo insuficiente para realizar o saque!")
        else:
            print("\n!! Valor inválido para saque ou limite diário de saques atingido!(R$500.00)")
    
    def extrato(self):
        """
        Exibe o extrato da conta bancária.
        """
        print("\n<<<<    Extrato    >>>>\n")
        if not self.depositos and not self.saques:
            print("Não foram realizadas movimentações.")
        else:
            print(f"Saldo Anterior: R$ {self.primeiro_saldo}")
            print("--" * 16)
            for deposito in self.depositos:
                print(f"Depósito: R$ {deposito:.2f}")
            print("--" * 16)
            for saque in self.saques:
                print(f"Saque: R$ {saque:.2f}")
            print("--" * 16)
        print(f"Saldo atual: R$ {self.saldo:.2f}")
        input("\n--> Enter para sair ")

def obter_saldo():
    """
    Solicita ao usuário o saldo fictício da conta bancária.
    """
    while True:
        saldo = input("Escolha o valor do seu saldo fictício: R$ ")
        try:
            saldo = float(saldo)
            if saldo >= 0:
                print(f"\n>>> Tudo certo, seu saldo será R${saldo:.2f}")
                sleep(2)
                os.system('cls')
                return saldo
            else:
                print("\n!!! Valor inválido. O saldo deve ser um número positivo.")
                sleep(2)
                os.system('cls')

        except ValueError:
            print("\n!!! Valor inválido. Digite um número válido.")
            sleep(2)
            os.system('cls')
   
def menu():
    """
    Menu de exibição e interação com o usuário
    """

    while True:
        menu_ativo = True
        print("--"*16 + "\n   Bem vindo(a) ao Banco DIO\n" + "--"*16)
        print("Selecione a opção desejada:")
        print("1 - Depósito\n2 - Saque\n3 - Extrato\n4 - Sair\n")

        opcao = input("--> R: ")

        # interação para cada escolha do usuário
        if opcao == "1":
            # deposito
            while True:
                try:
                    valor = float(input("Qual o valor deseja depositar: R$ "))
                    banco.deposito(valor)
                    sleep(2)
                    os.system('cls')
                    break
                except:
                    print("\n!! Valor inválido tente novamente!\n")
                    sleep(2)
                    os.system('cls')

        elif opcao == "2":
             while True:
                try:
                    valor = float(input("Qual o valor deseja sacar: R$ "))
                    banco.saque(valor)
                    sleep(2)
                    os.system('cls')
                    break
                except:
                    print("\n!! Valor inválido tente novamente!\n")
                    sleep(2)
                    os.system('cls')

        elif opcao == "3":
            sleep(2)
            os.system('cls')
            banco.extrato()
            sleep(2)
            os.system('cls')
            break

        elif opcao == "4":
            sleep(2)
            print("\nTudo bem, ate Logo :)\n\ncreated by [Matheus Alves]\n")
            menu_ativo = False
            break
        else:
            print("Opção inválida, tente novamente!")
            sleep(2)
            os.system('cls')
        
    if menu_ativo:
        menu()
    else:
        return
        

# Obter Saldo Fictício
os.system('cls')
saldo = obter_saldo()

# Sistema de Uso
banco = SistemaBancario(saldo)

# Chama o menu de opções
menu()
