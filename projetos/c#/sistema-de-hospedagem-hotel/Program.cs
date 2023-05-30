using System;
using System.Collections.Generic;

// Classe que representa um hóspede
public class Hospede
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public DateTime DataCheckIn { get; set; }
    public DateTime DataCheckOut { get; set; }
}

// Classe que representa o hotel
public class Hotel
{
    private List<Hospede> hospedes;

    public Hotel()
    {
        hospedes = new List<Hospede>();
    }

    public void AdicionarHospede(Hospede hospede)
    {
        hospedes.Add(hospede);
        Console.WriteLine("Hóspede adicionado com sucesso!");
    }

    public void RemoverHospede(int id)
    {
        Hospede hospede = hospedes.Find(h => h.Id == id);
        if (hospede != null)
        {
            hospedes.Remove(hospede);
            Console.WriteLine("Hóspede removido com sucesso!");
        }
        else
        {
            Console.WriteLine("Hóspede não encontrado!");
        }
    }

    public void ListarHospedes()
    {
        Console.WriteLine("Lista de Hóspedes:");
        foreach (var hospede in hospedes)
        {
            Console.WriteLine($"ID: {hospede.Id}, Nome: {hospede.Nome}, Telefone: {hospede.Telefone}, Check-In: {hospede.DataCheckIn}, Check-Out: {hospede.DataCheckOut}");
        }
    }
}

// Classe principal do programa
public class Program
{
    public static void Main(string[] args)
    {
        Hotel hotel = new Hotel();

        // Adicionando hóspedes
        Hospede hospede1 = new Hospede
        {
            Id = 1,
            Nome = "João",
            Telefone = "123456789",
            DataCheckIn = DateTime.Now,
            DataCheckOut = DateTime.Now.AddDays(3)
        };
        hotel.AdicionarHospede(hospede1);

        Hospede hospede2 = new Hospede
        {
            Id = 2,
            Nome = "Maria",
            Telefone = "987654321",
            DataCheckIn = DateTime.Now,
            DataCheckOut = DateTime.Now.AddDays(5)
        };
        hotel.AdicionarHospede(hospede2);

        // Listando hóspedes
        hotel.ListarHospedes();

        // Removendo hóspede
        hotel.RemoverHospede(1);

        // Listando hóspedes novamente
        hotel.ListarHospedes();
    }
}

