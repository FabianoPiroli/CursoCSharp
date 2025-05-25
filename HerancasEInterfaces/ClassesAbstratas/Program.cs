using System;

abstract class Forma // Classe abstrata
{
    public abstract int CalcularArea(); // Método abstrato
}
class Quadrado : Forma // Classe derivada
{
    int lado; // Atributo
    public Quadrado(int n) => lado = n; // Construtor

    public override int CalcularArea() => lado * lado; // Sobrescrita
    // O operador => é usado para definir expressões lambda, que são uma forma concisa de escrever métodos de uma linha.
    // O override indica que este método está sobrescrevendo um método da classe base (Forma).
    // O método CalcularArea() calcula a área do quadrado multiplicando o lado por ele mesmo.
}
class Program
{
    static void Main(string[] args) // Método principal
    {
        var qd = new Quadrado(12); // Instanciação da classe

        Console.WriteLine($"Área do quadrado = {qd.CalcularArea()}"); // Chamada do método
        // O cifrão $ indica que a string é interpolada, permitindo incluir expressões dentro dela.
    }
}