# **Análise do Código - Sistema de Hospedagem de um Hotel em C#**

## **Estrutura do Código**

O código apresentado é um exemplo de um Sistema de Hospedagem de um Hotel em C# e está organizado em três partes principais: as classes `Hospede` e `Hotel`, e a classe `Program` que contém o método `Main` responsável pela execução do programa.

## **Classe Hospede**

A classe `Hospede` representa um hóspede do hotel e possui as seguintes propriedades:

- `Id`: Um identificador único para cada hóspede.
- `Nome`: O nome do hóspede.
- `Telefone`: O número de telefone do hóspede.
- `DataCheckIn`: A data de check-in, que indica quando o hóspede chegou ao hotel.
- `DataCheckOut`: A data de check-out, que indica quando o hóspede sairá do hotel.

## **Classe Hotel**

A classe `Hotel` representa o hotel em si e possui uma lista de hóspedes como uma propriedade privada. Ela contém os seguintes métodos:

- `AdicionarHospede(Hospede hospede)`: Adiciona um novo hóspede à lista de hóspedes do hotel.
- `RemoverHospede(int id)`: Remove um hóspede da lista de hóspedes com base no seu ID.
- `ListarHospedes()`: Exibe a lista de hóspedes do hotel no console.

A classe `Hotel` utiliza a lista `hospedes` para armazenar os objetos `Hospede`. O método `AdicionarHospede` adiciona um hóspede à lista, o método `RemoverHospede` remove um hóspede com base em seu ID e o método `ListarHospedes` exibe as informações de todos os hóspedes na lista.

## **Classe Program e o Método Main**

A classe `Program` contém o método `Main`, que é o ponto de entrada do programa. Dentro do método `Main`, é criada uma instância da classe `Hotel` chamada `hotel`.

Em seguida, são criadas instâncias da classe `Hospede` representando dois hóspedes diferentes. Cada hóspede possui um ID, nome, telefone, data de check-in e data de check-out. Os hóspedes são adicionados ao hotel usando o método `AdicionarHospede` e em seguida, é chamado o método `ListarHospedes` para exibir a lista de hóspedes no console.

Posteriormente, é chamado o método `RemoverHospede` para remover um hóspede específico pelo seu ID. Por fim, é novamente chamado o método `ListarHospedes` para exibir a lista atualizada de hóspedes no console.

## **Considerações Finais**

O código apresentado é um exemplo simples de um Sistema de Hospedagem de um Hotel em C#. Ele demonstra o uso de classes, propriedades, métodos e listas para gerenciar hóspedes em um hotel.

Esse código pode ser expandido adicionando mais funcionalidades, como busca de hóspedes por nome, cálculo de valores para estadias, verificação de disponibilidade de quartos, entre outros recursos que são comuns em sistemas de hospedagem.
