using System;
using System.Collections.Generic;

// Enumeração para os tipos de veículos
public enum TipoVeiculo
{
    Carro,
    Moto,
    Caminhao
}

// Classe que representa um veículo
public class Veiculo
{
    public string Placa { get; set; }
    public TipoVeiculo Tipo { get; set; }
    public DateTime DataEntrada { get; set; }
    public DateTime DataSaida { get; set; }
    public double ValorPagar { get; set; }
}

// Classe que representa o estacionamento
public class Estacionamento
{
    private List<Veiculo> veiculos;

    public Estacionamento()
    {
        veiculos = new List<Veiculo>();
    }

    public void EntradaVeiculo(Veiculo veiculo)
    {
        veiculos.Add(veiculo);
        Console.WriteLine($"Veículo de placa {veiculo.Placa} entrou no estacionamento.");
    }

    public void SaidaVeiculo(string placa)
    {
        Veiculo veiculo = veiculos.Find(v => v.Placa == placa);
        if (veiculo != null)
        {
            veiculo.DataSaida = DateTime.Now;
            veiculo.ValorPagar = CalcularValorPagar(veiculo);
            Console.WriteLine($"Veículo de placa {veiculo.Placa} saiu do estacionamento. Valor a pagar: {veiculo.ValorPagar}");
            veiculos.Remove(veiculo);
        }
        else
        {
            Console.WriteLine($"Veículo de placa {placa} não encontrado no estacionamento.");
        }
    }

    public void ListarVeiculosEstacionados()
    {
        Console.WriteLine("Veículos estacionados:");
        foreach (var veiculo in veiculos)
        {
            Console.WriteLine($"Placa: {veiculo.Placa}, Tipo: {veiculo.Tipo}, Data de Entrada: {veiculo.DataEntrada}");
        }
    }

    private double CalcularValorPagar(Veiculo veiculo)
    {
        // Lógica para calcular o valor a pagar com base no tipo de veículo e tempo de permanência
        // Neste exemplo, consideramos um valor fixo por hora
        TimeSpan tempoPermanencia = veiculo.DataSaida - veiculo.DataEntrada;
        double valorPorHora = 10.0; // Valor fixo por hora
        return Math.Ceiling(tempoPermanencia.TotalHours) * valorPorHora;
    }
}

// Classe principal do programa
public class Program
{
    public static void Main(string[] args)
    {
        Estacionamento estacionamento = new Estacionamento();

        // Entrada de veículos
        Veiculo carro1 = new Veiculo
        {
            Placa = "ABC123",
            Tipo = TipoVeiculo.Carro,
            DataEntrada = DateTime.Now
        };
        estacionamento.EntradaVeiculo(carro1);

        Veiculo moto1 = new Veiculo
        {
            Placa = "DEF456",
            Tipo = TipoVeiculo.Moto,
            DataEntrada = DateTime.Now
        };
        estacionamento.EntradaVeiculo(moto1);

        // Listando veículos estacionados
        estacionamento.ListarVeiculosEstacionados();

        // Saída de veículo
        estacionamento.SaidaVeiculo("ABC123");

        // Listando veículos estacionados novamente
        estacionamento.ListarVeiculosEstacionados();
    }
}

