
# **Análise do Código**

## **Estrutura do Código**

O código é escrito em C# e consiste em uma abstração de um sistema de celular. Ele define uma classe abstrata chamada `Celular`, que contém métodos e propriedades relacionadas a um celular genérico. Há também duas classes derivadas: `IPhone` e `Samsung`, que herdam da classe `Celular` e fornecem implementações específicas para os métodos abstratos.

A classe `Program` é a classe de entrada do programa, que contém o método `Main`. Nesse método, são criadas instâncias dos objetos `IPhone` e `Samsung`, e vários métodos são chamados para simular ações, como ligar, enviar mensagens e fazer chamadas.


**Análise do Exercicio**

## **Estrutura do Código**

### **Classe Celular**

A classe abstrata `Celular` define as propriedades `Marca` e `Modelo`, bem como os métodos `Ligar`, `Desligar`, `EnviarMensagem` e `FazerChamada`. Essa classe serve como uma base para os tipos específicos de celulares.

### **Classe IPhone**

A classe `IPhone` é uma classe derivada de `Celular` e fornece implementações concretas para os métodos abstratos. Ela define as propriedades `Marca` e `Modelo` como "Apple" e "iPhone", respectivamente. Os métodos `EnviarMensagem` e `FazerChamada` imprimem mensagens no console com as informações específicas do iPhone.

### **Classe Samsung**

A classe `Samsung` também é uma classe derivada de `Celular` e possui implementações concretas para os métodos abstratos. Ela define as propriedades `Marca` e `Modelo` como "Samsung" e "Galaxy", respectivamente. Os métodos `EnviarMensagem` e `FazerChamada` imprimem mensagens no console com as informações específicas do celular Samsung.

### **Classe Program**

A classe `Program` contém o método `Main`, que é o ponto de entrada do programa. Nele, são criadas instâncias de `IPhone` e `Samsung` e chamados vários métodos para simular ações de ligar, enviar mensagens e fazer chamadas. As mensagens impressas no console exibem informações específicas de cada objeto.

## **Execução do Código**

Ao executar o código, você verá mensagens impressas no console que simulam ações de um celular. Primeiro, um iPhone é ligado, uma mensagem é enviada e uma chamada é feita. Em seguida, um celular Samsung é ligado, uma mensagem é enviada e uma chamada é feita novamente. Cada ação é acompanhada das informações específicas do modelo de celular.
