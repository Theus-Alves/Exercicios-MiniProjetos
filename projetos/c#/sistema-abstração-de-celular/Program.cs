using System;

public abstract class Celular
{
    public abstract string Marca { get; }
    public abstract string Modelo { get; }
    
    public void Ligar()
    {
        Console.WriteLine($"Ligando o {Marca} {Modelo}...");
    }
    
    public void Desligar()
    {
        Console.WriteLine($"Desligando o {Marca} {Modelo}...");
    }
    
    public abstract void EnviarMensagem(string mensagem);
    public abstract void FazerChamada(string numero);
}

public class IPhone : Celular
{
    public override string Marca => "Apple";
    public override string Modelo => "iPhone";
    
    public override void EnviarMensagem(string mensagem)
    {
        Console.WriteLine($"Enviando mensagem do {Marca} {Modelo}: {mensagem}");
    }
    
    public override void FazerChamada(string numero)
    {
        Console.WriteLine($"Fazendo chamada do {Marca} {Modelo}: {numero}");
    }
}

public class Samsung : Celular
{
    public override string Marca => "Samsung";
    public override string Modelo => "Galaxy";
    
    public override void EnviarMensagem(string mensagem)
    {
        Console.WriteLine($"Enviando mensagem do {Marca} {Modelo}: {mensagem}");
    }
    
    public override void FazerChamada(string numero)
    {
        Console.WriteLine($"Fazendo chamada do {Marca} {Modelo}: {numero}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Celular iphone = new IPhone();
        iphone.Ligar();
        iphone.EnviarMensagem("Olá, mundo!");
        iphone.FazerChamada("123456789");
        iphone.Desligar();
        
        Console.WriteLine();
        
        Celular samsung = new Samsung();
        samsung.Ligar();
        samsung.EnviarMensagem("Hello, world!");
        samsung.FazerChamada("987654321");
        samsung.Desligar();
    }
}

