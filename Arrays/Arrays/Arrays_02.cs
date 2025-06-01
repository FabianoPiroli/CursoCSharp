using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Arrays_02
    {
        static void Array_02(string[] args)
        {
            // 10 números inteiros > 0
            // Vetor que armazena números pares
            // Vetor que armazena números ímpares
            // Exibir TODOS os vetores em ordem crescente

            int[] numeros = new int[10];
            int[] pares = new int[10];
            int[] impares = new int[10];

            // Preencher o vetor de números inteiros
            for (int p = 0; p < numeros.Length; p++)
            {
                Console.Write("Digite um número maior do que zero\n");
                numeros[p] = Convert.ToInt32(Console.ReadLine());
            }

            // Ordenar o vetor de números inteiros
            for ( int p = 0; p < numeros.Length; p++)
            {
                if (numeros[p] % 2 == 0) // Verifica se o número é par quando o resto da divisão por 2 é igual a zero caso contrário é ímpar
                {
                    pares[p] = numeros[p]; // Adiciona o número par ao vetor de pares
                }
                else
                {
                    impares[p] = numeros[p]; // Adiciona o número ímpar ao vetor de ímpares
                }
            }

            // Ordenar vetores
            Array.Sort(numeros); // Ordena o vetor de números inteiros
            Array.Sort(pares); // Ordena o vetor de pares
            Array.Sort(impares); // Ordena o vetor de ímpares

            Console.WriteLine("Estes são os número que você digitou:\n");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("\n\nEstes são os números pares:\n");
            foreach (int numero in pares)
            {
                if (numero != 0) Console.WriteLine(numero); // Exibe apenas os números pares que são diferentes de zero
            }

            Console.WriteLine("\n\nEstes são os números ímpares:\n");
            {
                foreach (int numero in impares)
                {
                    if (numero != 0) Console.WriteLine(numero); // Exibe apenas os números ímpares que são diferentes de zero
                }
            }
        }
    }
}
