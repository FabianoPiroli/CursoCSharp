using System;

namespace Danki_Bank
{
    public class ContaCorrente
    {
        // Atributos
        private int Agencia;
        private int Numero;

        // Propriedades
        public static double TaxaOperacao { get; private set; }
        public static int TotalContasCriadas { get; private set; }

        // Construtor
        public ContaCorrente(int agencia, int numero)
        {
            // Verifica se a agência e o número da conta são válidos
            Agencia = agencia;
            Numero = numero;

            try
            {
                TotalContasCriadas++; // Incrementa o total de contas criadas
                TaxaOperacao = 30 / TotalContasCriadas; // Cálculo da taxa de operação
                Console.WriteLine("O resultado é:" + TaxaOperacao);

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não podemos dividir por zero!");
            }
        }

        // Classe principal para executar o programa
        class Program
        {
            static void Main(string[] args)
            {
                ContaCorrente conta1 = new ContaCorrente(9999, 123456);
                ContaCorrente conta2 = new ContaCorrente(8888, 654321);
                ContaCorrente conta3 = new ContaCorrente(7777, 987654);
                Console.ReadLine();
            }
        }
    }
}