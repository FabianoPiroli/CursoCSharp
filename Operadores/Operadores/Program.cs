using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // ToInt32 converte o valor lido para um número inteiro
            // ReadLine lê o valor digitado pelo usuário
            Console.WriteLine("Escreva um número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Escreva outro número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            // Soma os dois números
            int total = numero1 + numero2;

            // Exibe o resultado
            Console.WriteLine("A soma dos números é: ");
            Console.WriteLine(total);
            // Exibe o resultado com formatação
            // Formatação é uma forma de exibir o resultado com um formato específico
            // Exibe o resultado com interpolação de string
            // Interpolação de string é uma forma de incluir variáveis dentro de strings
            Console.WriteLine("O seu total é:\n" + total);

            /*
            // Operadores Aritméticos, Relacionais, Lógicos, de Incremento e Decremento
            // Operadores Aritméticos
            int a = 10;
            int b = 5;
            Console.WriteLine("Soma: " + (a + b));
            Console.WriteLine("Subtração: " + (a - b));
            Console.WriteLine("Multiplicação: " + (a * b));
            Console.WriteLine("Divisão: " + (a / b));
            Console.WriteLine("Módulo: " + (a % b));
            // Operadores Relacionais
            Console.WriteLine("Igual: " + (a == b));
            Console.WriteLine("Diferente: " + (a != b));
            Console.WriteLine("Maior: " + (a > b));
            Console.WriteLine("Menor: " + (a < b));
            Console.WriteLine("Maior ou Igual: " + (a >= b));
            Console.WriteLine("Menor ou Igual: " + (a <= b));
            // Operadores Lógicos
            bool x = true;
            bool y = false;
            Console.WriteLine("E: " + (x && y));
            Console.WriteLine("Ou: " + (x || y));
            Console.WriteLine("Não: " + (!x));
            // Operadores de Incremento e Decremento
            int c = 10;
            Console.WriteLine("Incremento: " + (++c));
            Console.WriteLine("Decremento: " + (--c));
            */
        }

    }
}