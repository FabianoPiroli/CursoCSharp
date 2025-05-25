using System;

class Program
{
    static void Main(string[] args)
    {
        // Estrutura Condicional
        // Operadoes de atribuição
        // Atribue um valor a uma variável
        int numero = 8;

        // Operadores de comparação
        // Compara dois valores e retorna um valor booleano
        // == compara se dois valores são iguais, que é diferente de = que apenas atribui um valor a uma variável
        if (numero == 8)
        {
            Console.WriteLine("Está Correto!");
        }
        else
        {
            Console.WriteLine("Está Errado!");
        }

        // Operadores lógicos
        // && e || são operadores lógicos que comparam dois valores booleanos
        // && retorna true se ambos os valores forem true
        // || retorna true se pelo menos um dos valores for true
        // ! é o operador de negação, que inverte o valor booleano
        // Exemplo de uso de operadores lógicos
        int numero1 = 8;
        int numero2 = 8;

        if (numero1 == 8 && numero2 == 8)
        {
            Console.WriteLine("Está Correto!");
        }
        else
        {
            Console.WriteLine("Está Errado!");
        }
        // Exemplo de uso de operadores lógicos com negação
        bool verdadeiro = true;

        // O operador ! inverte o valor booleano
        // Se verdadeiro for true, !verdadeiro será false
        if (!verdadeiro == true)
        {
            Console.WriteLine("É verdade");
        }
        else
        {
            Console.WriteLine("É mentira");
        }
    }
}