# **Relatório - Implementando Validações de Testes Unitários com C#**

## **Introdução**

Este relatório apresenta a implementação de testes unitários em C# utilizando a biblioteca NUnit. Os testes são realizados em uma classe `Calculator`, que contém os métodos `Add` e `Subtract` para executar operações matemáticas básicas.

## **Estrutura do Código**

O código está estruturado em duas partes principais: a classe `Calculator` e a classe `CalculatorTests`, que contém os testes unitários.

### **Classe Calculator**

A classe `Calculator` possui os seguintes métodos:

- `Add(int a, int b)`: Realiza a adição de dois números inteiros e retorna o resultado.
- `Subtract(int a, int b)`: Realiza a subtração de dois números inteiros e retorna o resultado.

Esses métodos são simples e servem como exemplo para demonstrar a implementação de testes unitários.

### **Classe CalculatorTests**

A classe `CalculatorTests` é decorada com o atributo `[TestFixture]`, indicando que é uma classe de testes. Ela contém dois métodos de teste, decorados com o atributo `[Test]`, que são responsáveis por testar os métodos da classe `Calculator`.

#### **Método Add_WhenCalled_ReturnsSumOfTwoNumbers**

Este método de teste verifica se o método `Add` da classe `Calculator` retorna corretamente a soma de dois números. O teste é realizado da seguinte forma:

1. **Arrange**: São definidos dois números inteiros `a` e `b` (5 e 10, respectivamente).
2. **Act**: O método `Add` é chamado com os valores `a` e `b` como argumentos.
3. **Assert**: É verificado se o resultado da adição é igual a 15.

#### **Método Subtract_WhenCalled_ReturnsDifferenceOfTwoNumbers**

Este método de teste verifica se o método `Subtract` da classe `Calculator` retorna corretamente a diferença de dois números. O teste é realizado da seguinte forma:

1. **Arrange**: São definidos dois números inteiros `a` e `b` (10 e 5, respectivamente).
2. **Act**: O método `Subtract` é chamado com os valores `a` e `b` como argumentos.
3. **Assert**: É verificado se o resultado da subtração é igual a 5.

## **Conclusão**

A implementação de testes unitários é uma prática essencial no desenvolvimento de software, pois ajuda a garantir a qualidade e robustez do código. Neste exemplo, utilizamos a biblioteca NUnit para criar testes unitários para os métodos da classe `Calculator`.

Os testes unitários verificam se os métodos estão produzindo os resultados esperados, o que auxilia na detecção precoce de erros e na manutenção do código.

É importante ressaltar que este é apenas um exemplo básico de implementação de testes unitários. Em um projeto real, é recomendado escrever uma variedade de testes que cubram diferentes cenários e casos de uso.

A prática de testes unitários contribui para um código mais confiável, facilita a identificação de problemas e promove a melhoria contínua do desenvolvimento de software.