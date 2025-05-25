using System;

namespace PrimeiroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Jogo de Perguntas e Respostas
            // Imprimir as perguntas na tela
            // Ler a resposta do usuário
            // Atribuir a resposta a uma variável
            // Verificar se a resposta está correta
            // Imprimir a resposta correta ou errada
            // Mostrar uma pontuação final

            // Variáveis
            int pontuacao = 0;
            int resposta1;
            int resposta2;
            string resposta3;
            string resposta4;
            float resposta5;

            // Início do jogo
            Console.WriteLine("Bem-vindo ao Jogo de Perguntas e Respostas!\n");

            // Pergunta1
            Console.WriteLine("Quanto é 5 + 5?\nEscreva sua resposta abaixo:");
            resposta1 = Convert.ToInt32(Console.ReadLine()); // Lê a resposta como inteiro convertendo a string
            if (resposta1 == 10)
            {
                Console.WriteLine("Resposta correta!\n");
                pontuacao++; // Adiciona 1 ponto à pontuação
                // Outra forma pode ser: pontuacao += 1;
            }
            else
            {
                Console.WriteLine("Resposta errada! A resposta correta é 10.\n");
            }

            // Pergunta2
            Console.WriteLine("Quanto é 10 + 5?\nEscreva sua resposta abaixo:");
            resposta2 = Convert.ToInt32(Console.ReadLine());
            if (resposta2 == 15)
            {
                Console.WriteLine("Resposta correta!\n");
                pontuacao++;
            }
            else
            {
                Console.WriteLine("Resposta errada! A resposta correta é 10.\n");
            }

            // Pergunta3
            Console.WriteLine("Quem é o CEO da Danki Code?\nEscreva sua resposta abaixo:");
            resposta3 = Console.ReadLine(); // Lê a resposta como string
            if (resposta3.Equals("Guilherme", StringComparison.OrdinalIgnoreCase)) // Ignora maiúsculas e minúsculas
            {
                Console.WriteLine("Resposta correta!\n");
                pontuacao++;
            }
            else
            {
                Console.WriteLine("Resposta errada! A resposta correta é Guilherme.\n");
            }

            // Pergunta4
            Console.WriteLine("Quem é o instrutor do Curso de C# da Danki Code?\nEscreva sua resposta abaixo:");
            resposta4 = Console.ReadLine();
            if (resposta4.Equals("Moises", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Resposta correta!\n");
                    pontuacao++;
            }
            else
            {
                Console.WriteLine("Resposta errada! A resposta correta é Moises.\n");
            }

            // Pergunta5
            Console.WriteLine("Quanto é 12.5 + 2? \nEscreva sua resposta abaixo:");
            resposta5 = float.Parse(Console.ReadLine()); // Lê a resposta como float

            if (resposta5 == 14.5f)
            {
                pontuacao++;
            }

            // Imprimir a pontuação final
            Console.WriteLine($"Sua pontuação final é: {pontuacao} de 5.\n");

        }
    }
}