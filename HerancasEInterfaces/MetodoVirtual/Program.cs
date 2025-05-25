using System;

public class Trabalhador
{
    public string? nome; // Atributo público

    protected decimal salarioBase; // Atributo protegido

    public Trabalhador(string nome, decimal salarioBase) // Construtor 
    {
        this.nome = nome; // Atributo público
        this.salarioBase = salarioBase; // Atributo protegido
    }

    public virtual decimal CalcularPagamento() // O método virtual pode ser sobrescrito por classes derivadas
    {
        return salarioBase; // Aqui, ele retorna o salário base do trabalhador
    }
}

public class vendasTrabalhador : Trabalhador // Herança
{
    private decimal bonusDeVendas; // Atributo privado

    public vendasTrabalhador(string nome, decimal salarioBase, decimal bonusDeVendas) : base(nome, salarioBase) // Construtor
    { 
        this.bonusDeVendas = bonusDeVendas; // Atributo privado
    }

    public override decimal CalcularPagamento() // Sobrescrevendo o método da classe base
                                                // a variável decimal é um tipo de dado que representa números decimais com precisão, usado para dinheiro
    {
        return salarioBase + bonusDeVendas; // Aqui, ele retorna o salário base mais o bônus de vendas
    }
}

class Program // Classe principal
{
    static void Main(string[] args)
    {
        var trabalhador1 = new vendasTrabalhador("Ana", 1000, 500); // Instância da classe derivada
        var trabalhador2 = new Trabalhador("Robson", 1200); // Instância da classe base

        Console.WriteLine($"Trabalhador1 {trabalhador1.nome} ganhou: {trabalhador1.CalcularPagamento()}");
        Console.WriteLine($"Trabalhador2 {trabalhador2.nome} ganhou: {trabalhador2.CalcularPagamento()}");
    }
}