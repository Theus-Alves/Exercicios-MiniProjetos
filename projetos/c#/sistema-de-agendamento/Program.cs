using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;


// Classe que representa uma tarefa
public class Tarefa
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Nome { get; set; }

    public DateTime DataAgendamento { get; set; }

    public bool Concluida { get; set; }
}

// Classe que representa o contexto do banco de dados
public class TarefaContext : DbContext
{
    public DbSet<Tarefa> Tarefas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("your_connection_string"); // Substitua pela sua connection string do SQL Server
    }
}

// Classe principal do programa
public class Program
{
    public static void Main(string[] args)
    {
        using (var db = new TarefaContext())
        {
            // Criar o banco de dados (se não existir) e executar as migrações pendentes
            db.Database.EnsureCreated();

            // Criar uma nova tarefa
            var novaTarefa = new Tarefa
            {
                Nome = "Completar projeto",
                DataAgendamento = DateTime.Now.AddDays(3),
                Concluida = false
            };

            // Adicionar a nova tarefa ao contexto e salvar no banco de dados
            db.Tarefas.Add(novaTarefa);
            db.SaveChanges();

            // Consultar todas as tarefas agendadas
            var tarefasAgendadas = db.Tarefas.ToList();

            Console.WriteLine("Tarefas Agendadas:");
            foreach (var tarefa in tarefasAgendadas)
            {
                Console.WriteLine($"{tarefa.Id} - {tarefa.Nome} ({tarefa.DataAgendamento})");
            }
        }
    }
}

