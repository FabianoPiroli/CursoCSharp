using System;

class Program
{
    static void Main(string[] args)
    {
        // Estruturas de repetição em C#
        // Laços de repetição são usados para executar um bloco de código várias vezes.
        // Existem três tipos principais de laços de repetição em C#: for, while e do-while.
        // Iteração é o processo de repetir um bloco de código várias vezes.
        /* Iterações são úteis quando precisamos executar um bloco de código várias vezes, 
        como em loops ou quando precisamos processar uma coleção de dados.*/

        // O laço for é usado quando sabemos o número de iterações que queremos fazer.
        // Ele é útil quando precisamos executar um bloco de código um número específico de vezes.
        // Exemplo de laço for
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Valor de i: {i}");
        }

        // O laço while é usado quando não sabemos o número de iterações que queremos fazer.
        // Ele continua executando enquanto uma condição for verdadeira.
        // Exemplo de laço while
        int j = 0;
        while (j < 10)
        {
            Console.WriteLine($"Valor de j: {j}");
            j++;
        }

        // O laço do-while é semelhante ao while, mas garante que o bloco de código seja executado pelo menos uma vez.
        // Ele continua executando enquanto uma condição for verdadeira, mas a condição é verificada após a execução do bloco de código.
        // Exemplo de laço do-while
        int k = 0;
        do
        {
            Console.WriteLine($"Valor de k: {k}");
            k++;
        } while (k < 10);

        // O laço foreach é usado para iterar sobre coleções, como arrays ou listas.
        // Ele é útil quando queremos percorrer todos os elementos de uma coleção sem precisar usar um índice.
        // Exemplo de laço foreach
        string[] frutas = { "maçã", "banana", "laranja" };
        foreach (string fruta in frutas)
        {
            Console.WriteLine($"Fruta: {fruta}");
        }
        // O laço for-each é uma forma simplificada de iterar sobre coleções.
        // Ele é mais legível e menos propenso a erros do que o laço for tradicional.

        // Exemplo de foreach com List
        List<int> numeros = new List<int>() { 1, 2, 3, 4, 5 };

        foreach (int numero in numeros)
        {
            Console.WriteLine($"Número: {numero}");

        }
    }
}