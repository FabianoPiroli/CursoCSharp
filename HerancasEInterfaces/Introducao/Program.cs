using System;

public class Alessandra
{
    private int valor = 10;
    public class Joao : Alessandra // Joao é uma classe que herda de Alessandra
    {
        public int PegarValor() // PegarValor é um método que retorna o valor da classe Alessandra
        {
            return this.valor; // this.valor é o valor da classe Alessandra
        }
    }
}

class Program // Classe principal
{
    static void Main(string[] args)
    {
        var Joao = new Alessandra.Joao(); // Joao é uma instância da classe Joao
        Console.WriteLine(Joao.PegarValor()); // Imprime o valor da classe Alessandra
    }
}