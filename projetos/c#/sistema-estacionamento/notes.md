# **Análise do Código - Sistema de Estacionamento em C#**

## **Estrutura do Código**

O código apresentado é um exemplo avançado de um Sistema de Estacionamento em C# e está organizado em três partes principais: as classes `Veiculo` e `Estacionamento`, e a classe `Program` que contém o método `Main` responsável pela execução do programa.

## **Classe Veiculo**

A classe `Veiculo` representa um veículo e possui as seguintes propriedades:

- `Placa`: A placa do veículo.
- `Tipo`: O tipo do veículo, representado por uma enumeração `TipoVeiculo`.
- `DataEntrada`: A data de entrada do veículo no estacionamento.
- `DataSaida`: A data de saída do veículo do estacionamento.
- `ValorPagar`: O valor a ser pago pelo veículo, calculado com base no tempo de permanência.

## **Classe Estacionamento**

A classe `Estacionamento` representa o estacionamento em si e possui uma lista de veículos estacionados como uma propriedade privada. Ela contém os seguintes métodos:

- `EntradaVeiculo(Veiculo veiculo)`: Adiciona um veículo à lista de veículos estacionados no estacionamento.
- `SaidaVeiculo(string placa)`: Remove um veículo da lista de veículos estacionados com base na sua placa.
- `ListarVeiculosEstacionados()`: Exibe a lista de veículos estacionados no console.

A classe `Estacionamento` utiliza a lista `veiculos` para armazenar os objetos `Veiculo`. O método `EntradaVeiculo` adiciona um veículo à lista, o método `SaidaVeiculo` remove um veículo com base em sua placa e o método `ListarVeiculosEstacionados` exibe as informações de todos os veículos na lista.

## **Classe Program e o Método Main**

A classe `Program` contém o método `Main`, que é o ponto de entrada do programa. Dentro do método `Main`, é criada uma instância da classe `Estacionamento` chamada `estacionamento`.

Em seguida, são criadas instâncias da classe `Veiculo` representando um carro e uma moto. Cada veículo possui uma placa, tipo, e a data de entrada. Os veículos são adicionados ao estacionamento usando o método `EntradaVeiculo` e em seguida, é chamado o método `ListarVeiculosEstacionados` para exibir a lista de veículos estacionados no console.

Posteriormente, é chamado o método `SaidaVeiculo` para simular a saída de um veículo com base na placa. O método calcula o valor a pagar com base no tipo de veículo e tempo de permanência e exibe o valor a pagar no console.

Por fim, é chamado novamente o método `ListarVeiculosEstacionados` para exibir a lista atualizada de veículos estacionados no console.

## **Considerações Finais**

O código apresentado é um exemplo avançado de um Sistema de Estacionamento em C#. Ele demonstra o uso de classes, propriedades, métodos, listas, enumerações e cálculos de valores para gerenciar veículos em um estacionamento.

Este código pode ser expandido adicionando mais funcionalidades, como controle de vagas disponíveis,

 integração com sistemas de pagamento, persistência de dados em um banco de dados, entre outras melhorias.

É importante observar que este exemplo possui um cálculo simples para o valor a pagar por hora, mas em um sistema real, podem existir outras regras e critérios para o cálculo correto do valor de estadia.

O código está bem estruturado, utilizando boas práticas de programação como encapsulamento, separação de responsabilidades e utilização de nomes significativos para as classes e métodos. No entanto, seria interessante adicionar tratamento de exceções para lidar com possíveis erros, como a entrada de uma placa inválida ou a tentativa de remover um veículo que não está estacionado.