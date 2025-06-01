using System;

namespace DankiCode
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] nomes;
            nomes = new string[5];

            // Para acessar o Nome é preciso informar o índice do array, ou seja o endereço do array.
            nomes[0] = "Joana"; 
            nomes[1] = "Roberto";
            nomes[2] = "João";
            nomes[3] = "Natália";
            nomes[4] = "Ana";

            // Para exibir o conteúdo do array, é necessário percorrer o array com um loop.
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }

        }
    }
}